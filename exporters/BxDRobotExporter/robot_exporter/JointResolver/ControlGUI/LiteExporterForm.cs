﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Inventor;
using System.Threading;
using OGLViewer;
using System.Threading.Tasks;

public partial class LiteExporterForm : Form
{
    public bool Exporting = false;

    public event EventHandler StartExport;
    public void OnStartExport()
    {
        StartExport?.Invoke(this, null);
    }

    public event EventHandler CancelExport;
    public void OnCancelExport()
    {
        CancelExport?.Invoke(this, null);
    }

    public static LiteExporterForm Instance;

    public LiteExporterForm()
    {
        InitializeComponent();
        LoadingAnimation.Image = JointResolver.Properties.Resources.LoadAnimation;
        Instance = this;
        LoadingAnimation.WaitOnLoad = true;
        ExporterWorker.WorkerReportsProgress = true;
        ExporterWorker.WorkerSupportsCancellation = true;
        ExporterWorker.DoWork += ExporterWorker_DoWork;
        ExporterWorker.RunWorkerCompleted += ExporterWorker_RunWorkerCompleted;

        Shown += delegate (object sender, EventArgs e)
        {
            if (InventorManager.Instance == null)
            {
                MessageBox.Show("Couldn't detect a running instance of Inventor.");
                return;
            }

            InventorManager.Instance.UserInterfaceManager.UserInteractionDisabled = true;

            Exporting = true;
            OnStartExport();
            ExporterWorker.RunWorkerAsync();
        };

        FormClosing += delegate (object sender, FormClosingEventArgs e)
        {
            InventorManager.Instance.UserInterfaceManager.UserInteractionDisabled = false;
        };
    }

    /// <summary>
    /// Updates the progress bar with an unknown state of progress, displaying a specific message.
    /// </summary>
    /// <param name="message">Message to display next to progress bar.</param>
    public void SetProgress(string message)
    {
        if (InvokeRequired)
        {
            BeginInvoke((Action<string>)SetProgress, message);
            return;
        }

        ProgressLabel.Text = message;
        ProgressBar.Style = ProgressBarStyle.Marquee;
    }

    /// <summary>
    /// Updates the progress bar with a specific state (i.e. 5/10 complete) and message (i.e. "Building model...").
    /// </summary>
    /// <param name="current">Current progress.</param>
    /// <param name="max">Maximum value for progress (what it will be when the process is complete). Uses previous value if less than 0.</param> 
    /// <param name="message">Message to display next to progress bar. Does not change text if message is null.</param>
    public void SetProgress(int current, int max = -1, string message = null)
    {
        if (InvokeRequired)
        {
            BeginInvoke((Action<int, int, string>)SetProgress, current, max, message);
            return;
        }

        if (message != null)
            ProgressLabel.Text = message;

        ProgressBar.Style = ProgressBarStyle.Continuous;

        if (max >= 0)
            ProgressBar.Maximum = max;

        if (current <= ProgressBar.Maximum)
            ProgressBar.Value = current;
        else
            ProgressBar.Value = ProgressBar.Maximum;
    }

    /// <summary>
    /// Updates the progress bar with a specific state (i.e. 50% complete) and message (i.e. "Building model...").
    /// </summary>
    /// <param name="current">Current progress as a percent (0 to 1).</param>
    /// <param name="message">Message to display next to progress bar. Does not change text if message is null.</param>
    public void SetProgressBar(double current, string message = null)
    {
        if (InvokeRequired)
        {
            BeginInvoke((Action<double, string>)SetProgressBar, current, message);
            return;
        }

        if (message != null)
            ProgressLabel.Text = message;
        ProgressBar.Style = ProgressBarStyle.Continuous;
        ProgressBar.Maximum = 10000;
        ProgressBar.Value = (int)(current * 10000);
    }

    /// <summary>
    /// Executes the functions that export the robot
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ExporterWorker_DoWork(object sender, DoWorkEventArgs e)
    {
        if (InventorManager.Instance.ActiveDocument == null || !(InventorManager.Instance.ActiveDocument is AssemblyDocument))
        {
            MessageBox.Show("Couldn't detect an open assembly");
            return;
        }

        if (SynthesisGUI.Instance.SkeletonBase == null)
            return; // Skeleton has not been built

        List<BXDAMesh> Meshes = ExportMeshesLite(SynthesisGUI.Instance.SkeletonBase, SynthesisGUI.Instance.RMeta.TotalWeightKg);

        SynthesisGUI.Instance.Meshes = Meshes;
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
        if (ExporterWorker.IsBusy)
            ExporterWorker.CancelAsync();

        if (ExporterWorker.CancellationPending)
            Dispose();
    }

    private void ExporterWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        Exporting = false;

        if (e.Cancelled)
            ProgressLabel.Text = "Export Cancelled";
        else if (e.Error != null)
        {
            ProgressLabel.Text = "An error occurred.";
            #region DEBUG SWITCH
#if DEBUG
            MessageBox.Show(e.Error.ToString());
#else
            MessageBox.Show(e.Error.Message);
#endif
        }
        #endregion
        else
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }

    /// <summary>
    /// The lite equivalent of the 'Start Exporter' <see cref="Button"/> in the <see cref="ExporterForm"/>. Used in <see cref="ExporterWorker_DoWork(Object, "/>
    /// </summary>
    /// <seealso cref="ExporterWorker_DoWork"/>
    /// <param name="baseNode"></param>
    /// <returns></returns>
    public List<BXDAMesh> ExportMeshesLite(RigidNode_Base baseNode, float totalMassKg)
    {
        BXDJSkeleton.SetupFileNames(baseNode);

        List<RigidNode_Base> nodes = new List<RigidNode_Base>();
        baseNode.ListAllNodes(nodes);

        // Meshes are stored in an array, indexed based upon the index of the node associated with them
        Dictionary<RigidNode_Base, int> nodeIndexDict = new Dictionary<RigidNode_Base, int>();
        for (int i = 0; i < nodes.Count; i++)
            nodeIndexDict.Add(nodes[i], i);

        BXDAMesh[] meshes = new BXDAMesh[nodes.Count];

        // Track progress of exporting
        SetProgressBar(0, "Exporting Model");
        Progress masterProgress = null;
        masterProgress = new Progress(() => { SetProgressBar(masterProgress.Status); });

        Dictionary<RigidNode_Base, Progress> nodeProgressDict = new Dictionary<RigidNode_Base, Progress>();
        foreach (RigidNode_Base node in nodes)
            nodeProgressDict.Add(node, new Progress(masterProgress));

        // Export each node
        SurfaceExporter.ClearAssets();

        Parallel.ForEach(nodes, (RigidNode_Base node) =>
        {
            Progress nodeProgress;
            lock (nodeProgressDict)
                nodeProgress = nodeProgressDict[node];

            if (node is RigidNode && node.GetModel() != null && node.ModelFileName != null && node.GetModel() is CustomRigidGroup)
            {
                try
                {
                    CustomRigidGroup group = (CustomRigidGroup)node.GetModel();

                    BXDAMesh output = SurfaceExporter.ExportAll(group, node.GUID, nodeProgress);

                    output.colliders.Clear();
                    output.colliders.AddRange(ConvexHullCalculator.GetHull(output));

                    meshes[nodeIndexDict[node]] = output;
                }
                catch (Exception e)
                {
                    throw new Exception("Error exporting mesh: " + node.GetModelID(), e);
                }
            }
        });

        // Apply custom mass to mesh by adjusting each node's mass so that the total equals the set mass
        if (totalMassKg > 0) // Negative value indicates that default mass should be left alone (TODO: Make default mass more accurate)
        {
            float totalDefaultMass = 0;
            for (int i = 0; i < nodes.Count; i++)
                totalDefaultMass += meshes[i].physics.mass;

            for (int i = 0; i < nodes.Count; i++)
                meshes[i].physics.mass = totalMassKg * (float)(meshes[i].physics.mass / totalDefaultMass);
        }

        // Add meshes to all nodes
        for (int i = 0; i < nodes.Count; i++)
            if (nodes[i] is OGL_RigidNode oglNode)
                oglNode.loadMeshes(meshes[i]);

        // Get wheel information (radius, center, etc.) for all wheels
        foreach (RigidNode_Base node in nodes)
        {
            SkeletalJoint_Base joint = node.GetSkeletalJoint();

            // Joint will be null if the node has no connection.
            // cDriver will be null if there is no driver connected to the joint.
            if (joint != null && joint.cDriver != null)
            {
                WheelDriverMeta wheelDriver = (WheelDriverMeta)joint.cDriver.GetInfo(typeof(WheelDriverMeta));

                // Drivers without wheel metadata do not need radius, center, or width info.
                if (wheelDriver != null)
                {
                    (node as OGLViewer.OGL_RigidNode).GetWheelInfo(out float radius, out float width, out BXDVector3 center);
                    wheelDriver.radius = radius;
                    wheelDriver.center = center;
                    wheelDriver.width = width;

                    joint.cDriver.AddInfo(wheelDriver);
                }
            }
        }

        return meshes.ToList();
    }
}