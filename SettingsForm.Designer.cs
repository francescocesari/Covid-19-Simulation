namespace Covid_19
{
    partial class SettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.LblSettingsTitle = new System.Windows.Forms.Label();
            this.ChkInterpersonalDistance = new System.Windows.Forms.CheckBox();
            this.ChkDPI = new System.Windows.Forms.CheckBox();
            this.TxtSimulationTime = new System.Windows.Forms.TextBox();
            this.LblSimulationTime = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblSpreadRay = new System.Windows.Forms.Label();
            this.TxtSpreadRay = new System.Windows.Forms.TextBox();
            this.LblPeopleNum = new System.Windows.Forms.Label();
            this.TxtPeopleNum = new System.Windows.Forms.TextBox();
            this.LblDeathProbability = new System.Windows.Forms.Label();
            this.TxtDeathProbability = new System.Windows.Forms.TextBox();
            this.LblSymptomlessLessProbaility = new System.Windows.Forms.Label();
            this.TxtSymptomlessProbability = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblSettingsTitle
            // 
            this.LblSettingsTitle.AutoSize = true;
            this.LblSettingsTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSettingsTitle.Location = new System.Drawing.Point(6, 9);
            this.LblSettingsTitle.Name = "LblSettingsTitle";
            this.LblSettingsTitle.Size = new System.Drawing.Size(167, 32);
            this.LblSettingsTitle.TabIndex = 0;
            this.LblSettingsTitle.Text = "Impostazioni";
            // 
            // ChkInterpersonalDistance
            // 
            this.ChkInterpersonalDistance.AutoSize = true;
            this.ChkInterpersonalDistance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkInterpersonalDistance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkInterpersonalDistance.Location = new System.Drawing.Point(12, 109);
            this.ChkInterpersonalDistance.Name = "ChkInterpersonalDistance";
            this.ChkInterpersonalDistance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkInterpersonalDistance.Size = new System.Drawing.Size(227, 22);
            this.ChkInterpersonalDistance.TabIndex = 6;
            this.ChkInterpersonalDistance.Text = "Distanza interpersonale (1m)";
            this.ChkInterpersonalDistance.UseVisualStyleBackColor = true;
            // 
            // ChkDPI
            // 
            this.ChkDPI.AutoSize = true;
            this.ChkDPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkDPI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkDPI.Location = new System.Drawing.Point(12, 149);
            this.ChkDPI.Name = "ChkDPI";
            this.ChkDPI.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkDPI.Size = new System.Drawing.Size(177, 22);
            this.ChkDPI.TabIndex = 7;
            this.ChkDPI.Text = "Utilizzo di DPI (FFP3)";
            this.ChkDPI.UseVisualStyleBackColor = true;
            // 
            // TxtSimulationTime
            // 
            this.TxtSimulationTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSimulationTime.Location = new System.Drawing.Point(206, 295);
            this.TxtSimulationTime.Name = "TxtSimulationTime";
            this.TxtSimulationTime.Size = new System.Drawing.Size(33, 22);
            this.TxtSimulationTime.TabIndex = 8;
            this.TxtSimulationTime.Text = "30";
            this.TxtSimulationTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblSimulationTime
            // 
            this.LblSimulationTime.AutoSize = true;
            this.LblSimulationTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSimulationTime.Location = new System.Drawing.Point(15, 296);
            this.LblSimulationTime.Name = "LblSimulationTime";
            this.LblSimulationTime.Size = new System.Drawing.Size(185, 18);
            this.LblSimulationTime.TabIndex = 9;
            this.LblSimulationTime.Text = "Velocità simulazione (ms)";
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(12, 361);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(371, 36);
            this.BtnStart.TabIndex = 10;
            this.BtnStart.Text = "AVVIA";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblSpreadRay
            // 
            this.LblSpreadRay.AutoSize = true;
            this.LblSpreadRay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSpreadRay.Location = new System.Drawing.Point(15, 190);
            this.LblSpreadRay.Name = "LblSpreadRay";
            this.LblSpreadRay.Size = new System.Drawing.Size(140, 18);
            this.LblSpreadRay.TabIndex = 12;
            this.LblSpreadRay.Text = "Raggio di contagio";
            // 
            // TxtSpreadRay
            // 
            this.TxtSpreadRay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSpreadRay.Location = new System.Drawing.Point(156, 189);
            this.TxtSpreadRay.Name = "TxtSpreadRay";
            this.TxtSpreadRay.Size = new System.Drawing.Size(33, 22);
            this.TxtSpreadRay.TabIndex = 11;
            this.TxtSpreadRay.Text = "6";
            this.TxtSpreadRay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblPeopleNum
            // 
            this.LblPeopleNum.AutoSize = true;
            this.LblPeopleNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeopleNum.Location = new System.Drawing.Point(12, 72);
            this.LblPeopleNum.Name = "LblPeopleNum";
            this.LblPeopleNum.Size = new System.Drawing.Size(141, 18);
            this.LblPeopleNum.TabIndex = 14;
            this.LblPeopleNum.Text = "Numero di persone";
            // 
            // TxtPeopleNum
            // 
            this.TxtPeopleNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPeopleNum.Location = new System.Drawing.Point(159, 72);
            this.TxtPeopleNum.Name = "TxtPeopleNum";
            this.TxtPeopleNum.Size = new System.Drawing.Size(61, 22);
            this.TxtPeopleNum.TabIndex = 13;
            this.TxtPeopleNum.Text = "200";
            this.TxtPeopleNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblDeathProbability
            // 
            this.LblDeathProbability.AutoSize = true;
            this.LblDeathProbability.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeathProbability.Location = new System.Drawing.Point(11, 229);
            this.LblDeathProbability.Name = "LblDeathProbability";
            this.LblDeathProbability.Size = new System.Drawing.Size(296, 18);
            this.LblDeathProbability.TabIndex = 16;
            this.LblDeathProbability.Text = "% probabilità di morte in caso di contagio";
            // 
            // TxtDeathProbability
            // 
            this.TxtDeathProbability.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDeathProbability.Location = new System.Drawing.Point(313, 228);
            this.TxtDeathProbability.Name = "TxtDeathProbability";
            this.TxtDeathProbability.Size = new System.Drawing.Size(33, 22);
            this.TxtDeathProbability.TabIndex = 15;
            this.TxtDeathProbability.Text = "2";
            this.TxtDeathProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblSymptomlessLessProbaility
            // 
            this.LblSymptomlessLessProbaility.AutoSize = true;
            this.LblSymptomlessLessProbaility.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSymptomlessLessProbaility.Location = new System.Drawing.Point(9, 263);
            this.LblSymptomlessLessProbaility.Name = "LblSymptomlessLessProbaility";
            this.LblSymptomlessLessProbaility.Size = new System.Drawing.Size(246, 18);
            this.LblSymptomlessLessProbaility.TabIndex = 18;
            this.LblSymptomlessLessProbaility.Text = "% probabilità di infetti asintomatici";
            // 
            // TxtSymptomlessProbability
            // 
            this.TxtSymptomlessProbability.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSymptomlessProbability.Location = new System.Drawing.Point(261, 263);
            this.TxtSymptomlessProbability.Name = "TxtSymptomlessProbability";
            this.TxtSymptomlessProbability.Size = new System.Drawing.Size(33, 22);
            this.TxtSymptomlessProbability.TabIndex = 17;
            this.TxtSymptomlessProbability.Text = "43";
            this.TxtSymptomlessProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 409);
            this.Controls.Add(this.LblSymptomlessLessProbaility);
            this.Controls.Add(this.TxtSymptomlessProbability);
            this.Controls.Add(this.LblDeathProbability);
            this.Controls.Add(this.TxtDeathProbability);
            this.Controls.Add(this.LblPeopleNum);
            this.Controls.Add(this.TxtPeopleNum);
            this.Controls.Add(this.LblSpreadRay);
            this.Controls.Add(this.TxtSpreadRay);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblSimulationTime);
            this.Controls.Add(this.TxtSimulationTime);
            this.Controls.Add(this.ChkDPI);
            this.Controls.Add(this.ChkInterpersonalDistance);
            this.Controls.Add(this.LblSettingsTitle);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Covid-19 Simulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSettingsTitle;
        private System.Windows.Forms.CheckBox ChkInterpersonalDistance;
        private System.Windows.Forms.CheckBox ChkDPI;
        private System.Windows.Forms.TextBox TxtSimulationTime;
        private System.Windows.Forms.Label LblSimulationTime;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblSpreadRay;
        private System.Windows.Forms.TextBox TxtSpreadRay;
        private System.Windows.Forms.Label LblPeopleNum;
        private System.Windows.Forms.TextBox TxtPeopleNum;
        private System.Windows.Forms.Label LblDeathProbability;
        private System.Windows.Forms.TextBox TxtDeathProbability;
        private System.Windows.Forms.Label LblSymptomlessLessProbaility;
        private System.Windows.Forms.TextBox TxtSymptomlessProbability;
    }
}