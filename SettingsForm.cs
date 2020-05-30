using System;
using System.Windows.Forms;

namespace Covid_19
{
    public partial class SettingsForm : Form
    {
        private readonly SimulationForm SimulationForm = new SimulationForm();

        public SettingsForm()
        {
            InitializeComponent();
            SimulationForm.Show();
            Location = new System.Drawing.Point(200, 289);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Settings.PeopleNum = Convert.ToInt32(TxtPeopleNum.Text);
            Settings.SimulationTime = Convert.ToInt32(TxtSimulationTime.Text);
            Settings.InterpersonalDistance = ChkInterpersonalDistance.Checked;
            Settings.DPI = ChkDPI.Checked;
            Settings.SpreadRay = Convert.ToInt32(TxtSpreadRay.Text);
            Settings.DeathProbability = Convert.ToInt32(TxtDeathProbability.Text);
            Settings.SymptomlessProbability = Convert.ToInt32(TxtSymptomlessProbability.Text);
            Settings.SpreadProbability = 20;
            if (Settings.InterpersonalDistance) Settings.SpreadProbability -= 8;
            if (Settings.DPI) Settings.SpreadProbability -= 10;
            SimulationForm.Reload();
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
