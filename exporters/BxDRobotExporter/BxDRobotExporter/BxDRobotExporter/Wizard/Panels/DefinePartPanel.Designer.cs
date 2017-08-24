﻿namespace BxDRobotExporter.Wizard
{
    partial class DefinePartPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NodeGroupBox = new System.Windows.Forms.GroupBox();
            this.JointLimitGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalFreedomLabel = new System.Windows.Forms.Label();
            this.FreedomFactorLabel = new System.Windows.Forms.Label();
            this.UpperLimitUpDown = new System.Windows.Forms.NumericUpDown();
            this.UpperLimitLabel = new System.Windows.Forms.Label();
            this.LowerLimitLabel = new System.Windows.Forms.Label();
            this.LowerLimitUpDown = new System.Windows.Forms.NumericUpDown();
            this.MetaTabControl = new System.Windows.Forms.TabControl();
            this.PneumaticTab = new System.Windows.Forms.TabPage();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.PneumaticPressureComboBox = new System.Windows.Forms.ComboBox();
            this.PneumaticDiameterComboBox = new System.Windows.Forms.ComboBox();
            this.DiameterLabel = new System.Windows.Forms.Label();
            this.ElevatorBrakeTab = new System.Windows.Forms.TabPage();
            this.BrakePortTwoUpDown = new System.Windows.Forms.NumericUpDown();
            this.BrakePortOneUpDown = new System.Windows.Forms.NumericUpDown();
            this.BrakePortLabel = new System.Windows.Forms.Label();
            this.HasBrakeCheckBox = new System.Windows.Forms.CheckBox();
            this.ElevatorStagesTab = new System.Windows.Forms.TabPage();
            this.ElevatorStagesComboBox = new System.Windows.Forms.ComboBox();
            this.PortsGroupBox = new System.Windows.Forms.GroupBox();
            this.AutoAssignCheckBox = new System.Windows.Forms.CheckBox();
            this.PortTwoUpDown = new System.Windows.Forms.NumericUpDown();
            this.PortTwoLabel = new System.Windows.Forms.Label();
            this.PortOneLabel = new System.Windows.Forms.Label();
            this.PortOneUpDown = new System.Windows.Forms.NumericUpDown();
            this.JointModeLabel = new System.Windows.Forms.Label();
            this.UnpoweredRadioButton = new System.Windows.Forms.RadioButton();
            this.PoweredRadioButton = new System.Windows.Forms.RadioButton();
            this.DriverComboBox = new System.Windows.Forms.ComboBox();
            this.SelectDriverLabel = new System.Windows.Forms.Label();
            this.MergeNodeButton = new System.Windows.Forms.Button();
            this.InventorHighlightButton = new System.Windows.Forms.Button();
            this.NodeGroupBox.SuspendLayout();
            this.JointLimitGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpperLimitUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerLimitUpDown)).BeginInit();
            this.MetaTabControl.SuspendLayout();
            this.PneumaticTab.SuspendLayout();
            this.ElevatorBrakeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrakePortTwoUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrakePortOneUpDown)).BeginInit();
            this.ElevatorStagesTab.SuspendLayout();
            this.PortsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortTwoUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortOneUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NodeGroupBox
            // 
            this.NodeGroupBox.Controls.Add(this.JointLimitGroupBox);
            this.NodeGroupBox.Controls.Add(this.MetaTabControl);
            this.NodeGroupBox.Controls.Add(this.PortsGroupBox);
            this.NodeGroupBox.Controls.Add(this.JointModeLabel);
            this.NodeGroupBox.Controls.Add(this.UnpoweredRadioButton);
            this.NodeGroupBox.Controls.Add(this.PoweredRadioButton);
            this.NodeGroupBox.Controls.Add(this.DriverComboBox);
            this.NodeGroupBox.Controls.Add(this.SelectDriverLabel);
            this.NodeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.NodeGroupBox.Name = "NodeGroupBox";
            this.NodeGroupBox.Size = new System.Drawing.Size(437, 189);
            this.NodeGroupBox.TabIndex = 0;
            this.NodeGroupBox.TabStop = false;
            this.NodeGroupBox.Text = "Empty";
            // 
            // JointLimitGroupBox
            // 
            this.JointLimitGroupBox.Controls.Add(this.TotalFreedomLabel);
            this.JointLimitGroupBox.Controls.Add(this.FreedomFactorLabel);
            this.JointLimitGroupBox.Controls.Add(this.UpperLimitUpDown);
            this.JointLimitGroupBox.Controls.Add(this.UpperLimitLabel);
            this.JointLimitGroupBox.Controls.Add(this.LowerLimitLabel);
            this.JointLimitGroupBox.Controls.Add(this.LowerLimitUpDown);
            this.JointLimitGroupBox.Location = new System.Drawing.Point(226, 101);
            this.JointLimitGroupBox.Name = "JointLimitGroupBox";
            this.JointLimitGroupBox.Size = new System.Drawing.Size(208, 79);
            this.JointLimitGroupBox.TabIndex = 13;
            this.JointLimitGroupBox.TabStop = false;
            this.JointLimitGroupBox.Text = "Joint Limits";
            // 
            // TotalFreedomLabel
            // 
            this.TotalFreedomLabel.AutoSize = true;
            this.TotalFreedomLabel.Location = new System.Drawing.Point(128, 34);
            this.TotalFreedomLabel.Name = "TotalFreedomLabel";
            this.TotalFreedomLabel.Size = new System.Drawing.Size(47, 13);
            this.TotalFreedomLabel.TabIndex = 5;
            this.TotalFreedomLabel.Text = "0.0 units";
            // 
            // FreedomFactorLabel
            // 
            this.FreedomFactorLabel.AutoSize = true;
            this.FreedomFactorLabel.Location = new System.Drawing.Point(128, 19);
            this.FreedomFactorLabel.Name = "FreedomFactorLabel";
            this.FreedomFactorLabel.Size = new System.Drawing.Size(51, 13);
            this.FreedomFactorLabel.TabIndex = 4;
            this.FreedomFactorLabel.Text = "Freedom:";
            // 
            // UpperLimitUpDown
            // 
            this.UpperLimitUpDown.Location = new System.Drawing.Point(72, 26);
            this.UpperLimitUpDown.Name = "UpperLimitUpDown";
            this.UpperLimitUpDown.Size = new System.Drawing.Size(46, 20);
            this.UpperLimitUpDown.TabIndex = 3;
            this.UpperLimitUpDown.ValueChanged += new System.EventHandler(this.UpperLimitUpDown_ValueChanged);
            // 
            // UpperLimitLabel
            // 
            this.UpperLimitLabel.AutoSize = true;
            this.UpperLimitLabel.Location = new System.Drawing.Point(6, 28);
            this.UpperLimitLabel.Name = "UpperLimitLabel";
            this.UpperLimitLabel.Size = new System.Drawing.Size(60, 13);
            this.UpperLimitLabel.TabIndex = 2;
            this.UpperLimitLabel.Text = "Upper Limit";
            // 
            // LowerLimitLabel
            // 
            this.LowerLimitLabel.AutoSize = true;
            this.LowerLimitLabel.Location = new System.Drawing.Point(6, 55);
            this.LowerLimitLabel.Name = "LowerLimitLabel";
            this.LowerLimitLabel.Size = new System.Drawing.Size(60, 13);
            this.LowerLimitLabel.TabIndex = 1;
            this.LowerLimitLabel.Text = "Lower Limit";
            // 
            // LowerLimitUpDown
            // 
            this.LowerLimitUpDown.Location = new System.Drawing.Point(72, 53);
            this.LowerLimitUpDown.Name = "LowerLimitUpDown";
            this.LowerLimitUpDown.Size = new System.Drawing.Size(45, 20);
            this.LowerLimitUpDown.TabIndex = 0;
            this.LowerLimitUpDown.ValueChanged += new System.EventHandler(this.LowerLimitUpDown_ValueChanged);
            // 
            // MetaTabControl
            // 
            this.MetaTabControl.Controls.Add(this.PneumaticTab);
            this.MetaTabControl.Controls.Add(this.ElevatorBrakeTab);
            this.MetaTabControl.Controls.Add(this.ElevatorStagesTab);
            this.MetaTabControl.Location = new System.Drawing.Point(10, 98);
            this.MetaTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.MetaTabControl.Name = "MetaTabControl";
            this.MetaTabControl.SelectedIndex = 0;
            this.MetaTabControl.Size = new System.Drawing.Size(211, 86);
            this.MetaTabControl.TabIndex = 12;
            // 
            // PneumaticTab
            // 
            this.PneumaticTab.Controls.Add(this.PressureLabel);
            this.PneumaticTab.Controls.Add(this.PneumaticPressureComboBox);
            this.PneumaticTab.Controls.Add(this.PneumaticDiameterComboBox);
            this.PneumaticTab.Controls.Add(this.DiameterLabel);
            this.PneumaticTab.Location = new System.Drawing.Point(4, 22);
            this.PneumaticTab.Margin = new System.Windows.Forms.Padding(2);
            this.PneumaticTab.Name = "PneumaticTab";
            this.PneumaticTab.Size = new System.Drawing.Size(203, 60);
            this.PneumaticTab.TabIndex = 1;
            this.PneumaticTab.Text = "Pneumatic";
            this.PneumaticTab.UseVisualStyleBackColor = true;
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.Location = new System.Drawing.Point(100, 9);
            this.PressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(48, 13);
            this.PressureLabel.TabIndex = 13;
            this.PressureLabel.Text = "Pressure";
            // 
            // PneumaticPressureComboBox
            // 
            this.PneumaticPressureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PneumaticPressureComboBox.FormattingEnabled = true;
            this.PneumaticPressureComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PneumaticPressureComboBox.Items.AddRange(new object[] {
            "60 psi",
            "20 psi",
            "10 psi"});
            this.PneumaticPressureComboBox.Location = new System.Drawing.Point(102, 26);
            this.PneumaticPressureComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PneumaticPressureComboBox.Name = "PneumaticPressureComboBox";
            this.PneumaticPressureComboBox.Size = new System.Drawing.Size(91, 21);
            this.PneumaticPressureComboBox.TabIndex = 6;
            // 
            // PneumaticDiameterComboBox
            // 
            this.PneumaticDiameterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PneumaticDiameterComboBox.FormattingEnabled = true;
            this.PneumaticDiameterComboBox.Items.AddRange(new object[] {
            "1 in",
            ".5 in",
            ".25 in"});
            this.PneumaticDiameterComboBox.Location = new System.Drawing.Point(4, 26);
            this.PneumaticDiameterComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PneumaticDiameterComboBox.Name = "PneumaticDiameterComboBox";
            this.PneumaticDiameterComboBox.Size = new System.Drawing.Size(94, 21);
            this.PneumaticDiameterComboBox.TabIndex = 12;
            // 
            // DiameterLabel
            // 
            this.DiameterLabel.AutoSize = true;
            this.DiameterLabel.Location = new System.Drawing.Point(2, 9);
            this.DiameterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiameterLabel.Name = "DiameterLabel";
            this.DiameterLabel.Size = new System.Drawing.Size(87, 13);
            this.DiameterLabel.TabIndex = 9;
            this.DiameterLabel.Text = "Internal Diameter";
            // 
            // ElevatorBrakeTab
            // 
            this.ElevatorBrakeTab.Controls.Add(this.BrakePortTwoUpDown);
            this.ElevatorBrakeTab.Controls.Add(this.BrakePortOneUpDown);
            this.ElevatorBrakeTab.Controls.Add(this.BrakePortLabel);
            this.ElevatorBrakeTab.Controls.Add(this.HasBrakeCheckBox);
            this.ElevatorBrakeTab.Location = new System.Drawing.Point(4, 22);
            this.ElevatorBrakeTab.Margin = new System.Windows.Forms.Padding(2);
            this.ElevatorBrakeTab.Name = "ElevatorBrakeTab";
            this.ElevatorBrakeTab.Size = new System.Drawing.Size(203, 60);
            this.ElevatorBrakeTab.TabIndex = 3;
            this.ElevatorBrakeTab.Text = "Brake Info";
            this.ElevatorBrakeTab.UseVisualStyleBackColor = true;
            // 
            // BrakePortTwoUpDown
            // 
            this.BrakePortTwoUpDown.Location = new System.Drawing.Point(106, 28);
            this.BrakePortTwoUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.BrakePortTwoUpDown.Name = "BrakePortTwoUpDown";
            this.BrakePortTwoUpDown.Size = new System.Drawing.Size(90, 20);
            this.BrakePortTwoUpDown.TabIndex = 3;
            // 
            // BrakePortOneUpDown
            // 
            this.BrakePortOneUpDown.Location = new System.Drawing.Point(8, 28);
            this.BrakePortOneUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.BrakePortOneUpDown.Name = "BrakePortOneUpDown";
            this.BrakePortOneUpDown.Size = new System.Drawing.Size(90, 20);
            this.BrakePortOneUpDown.TabIndex = 2;
            // 
            // BrakePortLabel
            // 
            this.BrakePortLabel.AutoSize = true;
            this.BrakePortLabel.Location = new System.Drawing.Point(8, 8);
            this.BrakePortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BrakePortLabel.Name = "BrakePortLabel";
            this.BrakePortLabel.Size = new System.Drawing.Size(57, 13);
            this.BrakePortLabel.TabIndex = 1;
            this.BrakePortLabel.Text = "Brake Port";
            // 
            // HasBrakeCheckBox
            // 
            this.HasBrakeCheckBox.AutoSize = true;
            this.HasBrakeCheckBox.Location = new System.Drawing.Point(120, 8);
            this.HasBrakeCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.HasBrakeCheckBox.Name = "HasBrakeCheckBox";
            this.HasBrakeCheckBox.Size = new System.Drawing.Size(76, 17);
            this.HasBrakeCheckBox.TabIndex = 0;
            this.HasBrakeCheckBox.Text = "Has Brake";
            this.HasBrakeCheckBox.UseVisualStyleBackColor = true;
            this.HasBrakeCheckBox.CheckedChanged += new System.EventHandler(this.chkBoxHasBrake_CheckedChanged);
            // 
            // ElevatorStagesTab
            // 
            this.ElevatorStagesTab.Controls.Add(this.ElevatorStagesComboBox);
            this.ElevatorStagesTab.Location = new System.Drawing.Point(4, 22);
            this.ElevatorStagesTab.Margin = new System.Windows.Forms.Padding(2);
            this.ElevatorStagesTab.Name = "ElevatorStagesTab";
            this.ElevatorStagesTab.Size = new System.Drawing.Size(203, 60);
            this.ElevatorStagesTab.TabIndex = 4;
            this.ElevatorStagesTab.Text = "Stages";
            this.ElevatorStagesTab.UseVisualStyleBackColor = true;
            // 
            // ElevatorStagesComboBox
            // 
            this.ElevatorStagesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ElevatorStagesComboBox.FormattingEnabled = true;
            this.ElevatorStagesComboBox.Items.AddRange(new object[] {
            "Single Stage Elevator",
            "Cascading Stage One",
            "Cascading Stage Two",
            "Continuous Stage One",
            "Continuos Stage Two"});
            this.ElevatorStagesComboBox.Location = new System.Drawing.Point(2, 21);
            this.ElevatorStagesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ElevatorStagesComboBox.Name = "ElevatorStagesComboBox";
            this.ElevatorStagesComboBox.Size = new System.Drawing.Size(199, 21);
            this.ElevatorStagesComboBox.TabIndex = 0;
            // 
            // PortsGroupBox
            // 
            this.PortsGroupBox.Controls.Add(this.AutoAssignCheckBox);
            this.PortsGroupBox.Controls.Add(this.PortTwoUpDown);
            this.PortsGroupBox.Controls.Add(this.PortTwoLabel);
            this.PortsGroupBox.Controls.Add(this.PortOneLabel);
            this.PortsGroupBox.Controls.Add(this.PortOneUpDown);
            this.PortsGroupBox.Location = new System.Drawing.Point(10, 44);
            this.PortsGroupBox.Name = "PortsGroupBox";
            this.PortsGroupBox.Size = new System.Drawing.Size(334, 51);
            this.PortsGroupBox.TabIndex = 6;
            this.PortsGroupBox.TabStop = false;
            this.PortsGroupBox.Text = "Ports";
            // 
            // AutoAssignCheckBox
            // 
            this.AutoAssignCheckBox.AutoSize = true;
            this.AutoAssignCheckBox.Location = new System.Drawing.Point(246, 20);
            this.AutoAssignCheckBox.Name = "AutoAssignCheckBox";
            this.AutoAssignCheckBox.Size = new System.Drawing.Size(82, 17);
            this.AutoAssignCheckBox.TabIndex = 4;
            this.AutoAssignCheckBox.Text = "Auto-Assign";
            this.AutoAssignCheckBox.UseVisualStyleBackColor = true;
            this.AutoAssignCheckBox.CheckedChanged += new System.EventHandler(this.AutoAssignCheckBox_CheckedChanged);
            // 
            // PortTwoUpDown
            // 
            this.PortTwoUpDown.Location = new System.Drawing.Point(147, 19);
            this.PortTwoUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PortTwoUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.PortTwoUpDown.Name = "PortTwoUpDown";
            this.PortTwoUpDown.Size = new System.Drawing.Size(47, 20);
            this.PortTwoUpDown.TabIndex = 3;
            this.PortTwoUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // PortTwoLabel
            // 
            this.PortTwoLabel.AutoSize = true;
            this.PortTwoLabel.Location = new System.Drawing.Point(103, 21);
            this.PortTwoLabel.Name = "PortTwoLabel";
            this.PortTwoLabel.Size = new System.Drawing.Size(38, 13);
            this.PortTwoLabel.TabIndex = 2;
            this.PortTwoLabel.Text = "Port 2:";
            // 
            // PortOneLabel
            // 
            this.PortOneLabel.AutoSize = true;
            this.PortOneLabel.Location = new System.Drawing.Point(6, 21);
            this.PortOneLabel.Name = "PortOneLabel";
            this.PortOneLabel.Size = new System.Drawing.Size(38, 13);
            this.PortOneLabel.TabIndex = 1;
            this.PortOneLabel.Text = "Port 1:";
            // 
            // PortOneUpDown
            // 
            this.PortOneUpDown.Location = new System.Drawing.Point(50, 19);
            this.PortOneUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PortOneUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.PortOneUpDown.Name = "PortOneUpDown";
            this.PortOneUpDown.Size = new System.Drawing.Size(47, 20);
            this.PortOneUpDown.TabIndex = 0;
            this.PortOneUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // JointModeLabel
            // 
            this.JointModeLabel.AutoSize = true;
            this.JointModeLabel.Location = new System.Drawing.Point(354, 20);
            this.JointModeLabel.Name = "JointModeLabel";
            this.JointModeLabel.Size = new System.Drawing.Size(62, 13);
            this.JointModeLabel.TabIndex = 5;
            this.JointModeLabel.Text = "Joint Mode:";
            // 
            // UnpoweredRadioButton
            // 
            this.UnpoweredRadioButton.AutoSize = true;
            this.UnpoweredRadioButton.Location = new System.Drawing.Point(357, 64);
            this.UnpoweredRadioButton.Name = "UnpoweredRadioButton";
            this.UnpoweredRadioButton.Size = new System.Drawing.Size(80, 17);
            this.UnpoweredRadioButton.TabIndex = 4;
            this.UnpoweredRadioButton.Text = "Unpowered";
            this.UnpoweredRadioButton.UseVisualStyleBackColor = true;
            this.UnpoweredRadioButton.CheckedChanged += new System.EventHandler(this.UnpoweredRadioButton_CheckedChanged);
            // 
            // PoweredRadioButton
            // 
            this.PoweredRadioButton.AutoSize = true;
            this.PoweredRadioButton.Checked = true;
            this.PoweredRadioButton.Location = new System.Drawing.Point(357, 41);
            this.PoweredRadioButton.Name = "PoweredRadioButton";
            this.PoweredRadioButton.Size = new System.Drawing.Size(67, 17);
            this.PoweredRadioButton.TabIndex = 3;
            this.PoweredRadioButton.TabStop = true;
            this.PoweredRadioButton.Text = "Powered";
            this.PoweredRadioButton.UseVisualStyleBackColor = true;
            this.PoweredRadioButton.CheckedChanged += new System.EventHandler(this.PoweredRadioButton_CheckedChanged);
            // 
            // DriverComboBox
            // 
            this.DriverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DriverComboBox.FormattingEnabled = true;
            this.DriverComboBox.Items.AddRange(new object[] {
            "Motor",
            "Servo",
            "Bumper Pneumatic",
            "Relay Pneumatic",
            "Worm Screw",
            "Dual Motor",
            "Elevator"});
            this.DriverComboBox.Location = new System.Drawing.Point(84, 17);
            this.DriverComboBox.Name = "DriverComboBox";
            this.DriverComboBox.Size = new System.Drawing.Size(260, 21);
            this.DriverComboBox.TabIndex = 2;
            this.DriverComboBox.SelectedIndexChanged += new System.EventHandler(this.DriverComboBox_SelectedIndexChanged);
            // 
            // SelectDriverLabel
            // 
            this.SelectDriverLabel.AutoSize = true;
            this.SelectDriverLabel.Location = new System.Drawing.Point(7, 20);
            this.SelectDriverLabel.Name = "SelectDriverLabel";
            this.SelectDriverLabel.Size = new System.Drawing.Size(71, 13);
            this.SelectDriverLabel.TabIndex = 1;
            this.SelectDriverLabel.Text = "Select Driver:";
            // 
            // MergeNodeButton
            // 
            this.MergeNodeButton.Location = new System.Drawing.Point(4, 194);
            this.MergeNodeButton.Name = "MergeNodeButton";
            this.MergeNodeButton.Size = new System.Drawing.Size(212, 23);
            this.MergeNodeButton.TabIndex = 1;
            this.MergeNodeButton.Text = "Merge Node Into Parent";
            this.MergeNodeButton.UseVisualStyleBackColor = true;
            this.MergeNodeButton.Click += new System.EventHandler(this.MergeNodeButton_Click);
            // 
            // InventorHighlightButton
            // 
            this.InventorHighlightButton.Location = new System.Drawing.Point(222, 194);
            this.InventorHighlightButton.Name = "InventorHighlightButton";
            this.InventorHighlightButton.Size = new System.Drawing.Size(212, 23);
            this.InventorHighlightButton.TabIndex = 2;
            this.InventorHighlightButton.Text = "View Node in Inventor";
            this.InventorHighlightButton.UseVisualStyleBackColor = true;
            this.InventorHighlightButton.Click += new System.EventHandler(this.InventorHighlightButton_Click);
            // 
            // DefinePartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InventorHighlightButton);
            this.Controls.Add(this.MergeNodeButton);
            this.Controls.Add(this.NodeGroupBox);
            this.Name = "DefinePartPanel";
            this.Size = new System.Drawing.Size(437, 220);
            this.NodeGroupBox.ResumeLayout(false);
            this.NodeGroupBox.PerformLayout();
            this.JointLimitGroupBox.ResumeLayout(false);
            this.JointLimitGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpperLimitUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerLimitUpDown)).EndInit();
            this.MetaTabControl.ResumeLayout(false);
            this.PneumaticTab.ResumeLayout(false);
            this.PneumaticTab.PerformLayout();
            this.ElevatorBrakeTab.ResumeLayout(false);
            this.ElevatorBrakeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrakePortTwoUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrakePortOneUpDown)).EndInit();
            this.ElevatorStagesTab.ResumeLayout(false);
            this.PortsGroupBox.ResumeLayout(false);
            this.PortsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortTwoUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortOneUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NodeGroupBox;
        private System.Windows.Forms.Label SelectDriverLabel;
        private System.Windows.Forms.Label JointModeLabel;
        private System.Windows.Forms.RadioButton UnpoweredRadioButton;
        private System.Windows.Forms.RadioButton PoweredRadioButton;
        private System.Windows.Forms.ComboBox DriverComboBox;
        private System.Windows.Forms.GroupBox PortsGroupBox;
        private System.Windows.Forms.CheckBox AutoAssignCheckBox;
        private System.Windows.Forms.NumericUpDown PortTwoUpDown;
        private System.Windows.Forms.Label PortTwoLabel;
        private System.Windows.Forms.Label PortOneLabel;
        private System.Windows.Forms.NumericUpDown PortOneUpDown;
        private System.Windows.Forms.TabControl MetaTabControl;
        private System.Windows.Forms.TabPage PneumaticTab;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.ComboBox PneumaticPressureComboBox;
        private System.Windows.Forms.ComboBox PneumaticDiameterComboBox;
        private System.Windows.Forms.Label DiameterLabel;
        private System.Windows.Forms.TabPage ElevatorBrakeTab;
        private System.Windows.Forms.NumericUpDown BrakePortTwoUpDown;
        private System.Windows.Forms.NumericUpDown BrakePortOneUpDown;
        private System.Windows.Forms.Label BrakePortLabel;
        private System.Windows.Forms.CheckBox HasBrakeCheckBox;
        private System.Windows.Forms.TabPage ElevatorStagesTab;
        private System.Windows.Forms.ComboBox ElevatorStagesComboBox;
        private System.Windows.Forms.GroupBox JointLimitGroupBox;
        private System.Windows.Forms.NumericUpDown UpperLimitUpDown;
        private System.Windows.Forms.Label UpperLimitLabel;
        private System.Windows.Forms.Label LowerLimitLabel;
        private System.Windows.Forms.NumericUpDown LowerLimitUpDown;
        private System.Windows.Forms.Label TotalFreedomLabel;
        private System.Windows.Forms.Label FreedomFactorLabel;
        private System.Windows.Forms.Button MergeNodeButton;
        private System.Windows.Forms.Button InventorHighlightButton;
    }
}