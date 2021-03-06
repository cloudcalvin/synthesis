﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorsLibrary
{
    public partial class SetWeightForm : Form
    {
        public float TotalWeightKg = 0;
        public bool PreferMetric = false;

        public SetWeightForm()
        {
            InitializeComponent();

            TotalWeightKg = SynthesisGUI.Instance.RMeta.TotalWeightKg;
            PreferMetric = SynthesisGUI.Instance.RMeta.PreferMetric;

            SetWeightBoxValue(TotalWeightKg * (PreferMetric ? 1 : 2.20462f));
            CalculatedWeightCheck.Checked = TotalWeightKg <= 0;
            UnitBox.SelectedIndex = PreferMetric ? 1 : 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            PreferMetric = UnitBox.SelectedIndex == 1;

            if (CalculatedWeightCheck.Checked)
                TotalWeightKg = -1;
            else
            {
                if (!PreferMetric)
                    TotalWeightKg = (float)WeightBox.Value / 2.20462f;
                else
                    TotalWeightKg = (float)WeightBox.Value;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CalculatedWeightCheck_CheckedChanged(object sender, EventArgs e)
        {
            WeightBox.Enabled = !CalculatedWeightCheck.Checked;
            WeightBox.Minimum = CalculatedWeightCheck.Checked ? 0 : 1;
            WeightBox.Value = CalculatedWeightCheck.Checked ? 0 : 100;
            UnitBox.Enabled = !CalculatedWeightCheck.Checked;
        }

        private void SetWeightBoxValue(float value)
        {
            if ((decimal)value > WeightBox.Maximum)
                WeightBox.Value = WeightBox.Maximum;
            else if ((decimal)value >= WeightBox.Minimum)
                WeightBox.Value = (decimal)value;
            else
                WeightBox.Value = 0;
        }
    }
}
