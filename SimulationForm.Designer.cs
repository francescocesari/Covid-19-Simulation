using System;

namespace Covid_19
{
    partial class SimulationForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationForm));
            this.SimulationTimer = new System.Windows.Forms.Timer(this.components);
            this.DayTimer = new System.Windows.Forms.Timer(this.components);
            this.LblCured = new System.Windows.Forms.Label();
            this.LblDeath = new System.Windows.Forms.Label();
            this.LblQuarantine = new System.Windows.Forms.Label();
            this.LblSympomless = new System.Windows.Forms.Label();
            this.LblInfected = new System.Windows.Forms.Label();
            this.LblPeopleAlive = new System.Windows.Forms.Label();
            this.LblDay = new System.Windows.Forms.Label();
            this.DataChart = new LiveCharts.WinForms.CartesianChart();
            this.PctPlayPlause = new System.Windows.Forms.PictureBox();
            this.SimulationPanel = new Covid_19.DoubleBufferedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PctPlayPlause)).BeginInit();
            this.SuspendLayout();
            // 
            // SimulationTimer
            // 
            this.SimulationTimer.Interval = 30;
            this.SimulationTimer.Tick += new System.EventHandler(this.SimulationTimer_Tick);
            // 
            // DayTimer
            // 
            this.DayTimer.Interval = 1000;
            this.DayTimer.Tick += new System.EventHandler(this.DayTimer_Tick);
            // 
            // LblCured
            // 
            this.LblCured.AutoSize = true;
            this.LblCured.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LblCured.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCured.ForeColor = System.Drawing.Color.Black;
            this.LblCured.Location = new System.Drawing.Point(562, 507);
            this.LblCured.Name = "LblCured";
            this.LblCured.Padding = new System.Windows.Forms.Padding(5);
            this.LblCured.Size = new System.Drawing.Size(77, 28);
            this.LblCured.TabIndex = 30;
            this.LblCured.Text = "Curati: 0";
            // 
            // LblDeath
            // 
            this.LblDeath.AutoSize = true;
            this.LblDeath.BackColor = System.Drawing.Color.Gainsboro;
            this.LblDeath.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeath.ForeColor = System.Drawing.Color.Black;
            this.LblDeath.Location = new System.Drawing.Point(894, 507);
            this.LblDeath.Name = "LblDeath";
            this.LblDeath.Padding = new System.Windows.Forms.Padding(5);
            this.LblDeath.Size = new System.Drawing.Size(98, 28);
            this.LblDeath.TabIndex = 29;
            this.LblDeath.Text = "Deceduti: 0";
            // 
            // LblQuarantine
            // 
            this.LblQuarantine.AutoSize = true;
            this.LblQuarantine.BackColor = System.Drawing.Color.LightGray;
            this.LblQuarantine.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuarantine.ForeColor = System.Drawing.Color.DarkCyan;
            this.LblQuarantine.Location = new System.Drawing.Point(669, 507);
            this.LblQuarantine.Name = "LblQuarantine";
            this.LblQuarantine.Padding = new System.Windows.Forms.Padding(5);
            this.LblQuarantine.Size = new System.Drawing.Size(195, 28);
            this.LblQuarantine.TabIndex = 28;
            this.LblQuarantine.Text = "Persone in quarantena: 0";
            // 
            // LblSympomless
            // 
            this.LblSympomless.AutoSize = true;
            this.LblSympomless.BackColor = System.Drawing.Color.Magenta;
            this.LblSympomless.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSympomless.ForeColor = System.Drawing.Color.Indigo;
            this.LblSympomless.Location = new System.Drawing.Point(369, 507);
            this.LblSympomless.Name = "LblSympomless";
            this.LblSympomless.Padding = new System.Windows.Forms.Padding(5);
            this.LblSympomless.Size = new System.Drawing.Size(163, 28);
            this.LblSympomless.TabIndex = 27;
            this.LblSympomless.Text = "Infetti asintomatici: 0";
            // 
            // LblInfected
            // 
            this.LblInfected.AutoSize = true;
            this.LblInfected.BackColor = System.Drawing.Color.Red;
            this.LblInfected.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfected.ForeColor = System.Drawing.Color.White;
            this.LblInfected.Location = new System.Drawing.Point(184, 507);
            this.LblInfected.Name = "LblInfected";
            this.LblInfected.Padding = new System.Windows.Forms.Padding(5);
            this.LblInfected.Size = new System.Drawing.Size(155, 28);
            this.LblInfected.TabIndex = 26;
            this.LblInfected.Text = "Infetti sintomatici: 0";
            // 
            // LblPeopleAlive
            // 
            this.LblPeopleAlive.AutoSize = true;
            this.LblPeopleAlive.BackColor = System.Drawing.Color.LightBlue;
            this.LblPeopleAlive.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeopleAlive.Location = new System.Drawing.Point(13, 507);
            this.LblPeopleAlive.Name = "LblPeopleAlive";
            this.LblPeopleAlive.Padding = new System.Windows.Forms.Padding(5);
            this.LblPeopleAlive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblPeopleAlive.Size = new System.Drawing.Size(141, 28);
            this.LblPeopleAlive.TabIndex = 25;
            this.LblPeopleAlive.Text = "Persone in vita: 0";
            // 
            // LblDay
            // 
            this.LblDay.AutoSize = true;
            this.LblDay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDay.Location = new System.Drawing.Point(12, 21);
            this.LblDay.Name = "LblDay";
            this.LblDay.Size = new System.Drawing.Size(80, 19);
            this.LblDay.TabIndex = 31;
            this.LblDay.Text = "Giorno: 0";
            // 
            // DataChart
            // 
            this.DataChart.BackColor = System.Drawing.Color.White;
            this.DataChart.Location = new System.Drawing.Point(12, 51);
            this.DataChart.Name = "DataChart";
            this.DataChart.Padding = new System.Windows.Forms.Padding(10);
            this.DataChart.Size = new System.Drawing.Size(353, 450);
            this.DataChart.TabIndex = 32;
            this.DataChart.Text = "DataChart";
            // 
            // PctPlayPlause
            // 
            this.PctPlayPlause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctPlayPlause.Image = ((System.Drawing.Image)(resources.GetObject("PctPlayPlause.Image")));
            this.PctPlayPlause.Location = new System.Drawing.Point(985, 15);
            this.PctPlayPlause.Name = "PctPlayPlause";
            this.PctPlayPlause.Size = new System.Drawing.Size(30, 30);
            this.PctPlayPlause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctPlayPlause.TabIndex = 33;
            this.PctPlayPlause.TabStop = false;
            this.PctPlayPlause.Click += new System.EventHandler(this.PctPlayPlause_Click);
            // 
            // SimulationPanel
            // 
            this.SimulationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimulationPanel.Location = new System.Drawing.Point(371, 51);
            this.SimulationPanel.Name = "SimulationPanel";
            this.SimulationPanel.Size = new System.Drawing.Size(644, 450);
            this.SimulationPanel.TabIndex = 0;
            this.SimulationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SimulationPanel_Paint);
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 544);
            this.Controls.Add(this.PctPlayPlause);
            this.Controls.Add(this.DataChart);
            this.Controls.Add(this.LblDay);
            this.Controls.Add(this.LblCured);
            this.Controls.Add(this.SimulationPanel);
            this.Controls.Add(this.LblDeath);
            this.Controls.Add(this.LblPeopleAlive);
            this.Controls.Add(this.LblQuarantine);
            this.Controls.Add(this.LblInfected);
            this.Controls.Add(this.LblSympomless);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Covid-19 Simulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SimulationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PctPlayPlause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBufferedPanel SimulationPanel;
        private System.Windows.Forms.Timer SimulationTimer;
        private System.Windows.Forms.Timer DayTimer;
        private System.Windows.Forms.Label LblCured;
        private System.Windows.Forms.Label LblDeath;
        private System.Windows.Forms.Label LblQuarantine;
        private System.Windows.Forms.Label LblSympomless;
        private System.Windows.Forms.Label LblInfected;
        private System.Windows.Forms.Label LblPeopleAlive;
        private System.Windows.Forms.Label LblDay;
        private System.Windows.Forms.PictureBox PctPlayPlause;
        internal LiveCharts.WinForms.CartesianChart DataChart;
    }
}

