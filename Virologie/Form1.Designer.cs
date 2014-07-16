namespace Virologie
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HomeLabel = new System.Windows.Forms.Label();
            this.ScanLabel = new System.Windows.Forms.Label();
            this.SecurityLabel = new System.Windows.Forms.Label();
            this.WindowsTextBox = new System.Windows.Forms.RichTextBox();
            this.WindowsLabel = new System.Windows.Forms.Label();
            this.StayProtectedLabel = new System.Windows.Forms.Label();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.SettingsCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.ScanCheckBox = new System.Windows.Forms.CheckBox();
            this.SecurityCheckBox = new System.Windows.Forms.CheckBox();
            this.HomeCheckBox = new System.Windows.Forms.CheckBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxHome = new Virologie.GroupBoxHome();
            this.groupBoxScan1 = new Virologie.GroupBoxScan();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Location = new System.Drawing.Point(43, 153);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(35, 13);
            this.HomeLabel.TabIndex = 1;
            this.HomeLabel.Text = "Home";
            // 
            // ScanLabel
            // 
            this.ScanLabel.AutoSize = true;
            this.ScanLabel.Location = new System.Drawing.Point(43, 248);
            this.ScanLabel.Name = "ScanLabel";
            this.ScanLabel.Size = new System.Drawing.Size(32, 13);
            this.ScanLabel.TabIndex = 3;
            this.ScanLabel.Text = "Scan";
            // 
            // SecurityLabel
            // 
            this.SecurityLabel.AutoSize = true;
            this.SecurityLabel.Location = new System.Drawing.Point(36, 343);
            this.SecurityLabel.Name = "SecurityLabel";
            this.SecurityLabel.Size = new System.Drawing.Size(45, 13);
            this.SecurityLabel.TabIndex = 5;
            this.SecurityLabel.Text = "Security";
            // 
            // WindowsTextBox
            // 
            this.WindowsTextBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.WindowsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WindowsTextBox.Location = new System.Drawing.Point(0, 0);
            this.WindowsTextBox.Name = "WindowsTextBox";
            this.WindowsTextBox.Size = new System.Drawing.Size(800, 70);
            this.WindowsTextBox.TabIndex = 6;
            this.WindowsTextBox.Text = "";
            // 
            // WindowsLabel
            // 
            this.WindowsLabel.AutoSize = true;
            this.WindowsLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.WindowsLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowsLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.WindowsLabel.Location = new System.Drawing.Point(68, 9);
            this.WindowsLabel.Name = "WindowsLabel";
            this.WindowsLabel.Size = new System.Drawing.Size(227, 18);
            this.WindowsLabel.TabIndex = 7;
            this.WindowsLabel.Text = "Windows AntiVir Defender 2014";
            // 
            // StayProtectedLabel
            // 
            this.StayProtectedLabel.AutoSize = true;
            this.StayProtectedLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.StayProtectedLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StayProtectedLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.StayProtectedLabel.Location = new System.Drawing.Point(68, 27);
            this.StayProtectedLabel.Name = "StayProtectedLabel";
            this.StayProtectedLabel.Size = new System.Drawing.Size(253, 17);
            this.StayProtectedLabel.TabIndex = 8;
            this.StayProtectedLabel.Text = "Stay protected anywhere, at anytime !";
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.Location = new System.Drawing.Point(38, 438);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(42, 13);
            this.UpdateLabel.TabIndex = 11;
            this.UpdateLabel.Text = "Update";
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Location = new System.Drawing.Point(36, 533);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(45, 13);
            this.SettingsLabel.TabIndex = 13;
            this.SettingsLabel.Text = "Settings";
            // 
            // SettingsCheckBox
            // 
            this.SettingsCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SettingsCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsCheckBox.BackgroundImage")));
            this.SettingsCheckBox.Location = new System.Drawing.Point(30, 470);
            this.SettingsCheckBox.Name = "SettingsCheckBox";
            this.SettingsCheckBox.Size = new System.Drawing.Size(60, 60);
            this.SettingsCheckBox.TabIndex = 18;
            this.SettingsCheckBox.UseVisualStyleBackColor = true;
            this.SettingsCheckBox.Click += new System.EventHandler(this.SettingsCheckBox_Click);
            // 
            // UpdateCheckBox
            // 
            this.UpdateCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.UpdateCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateCheckBox.BackgroundImage")));
            this.UpdateCheckBox.Location = new System.Drawing.Point(30, 375);
            this.UpdateCheckBox.Name = "UpdateCheckBox";
            this.UpdateCheckBox.Size = new System.Drawing.Size(60, 60);
            this.UpdateCheckBox.TabIndex = 17;
            this.UpdateCheckBox.UseVisualStyleBackColor = true;
            this.UpdateCheckBox.Click += new System.EventHandler(this.UpdateCheckBox_Click);
            // 
            // ScanCheckBox
            // 
            this.ScanCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ScanCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScanCheckBox.BackgroundImage")));
            this.ScanCheckBox.Location = new System.Drawing.Point(30, 185);
            this.ScanCheckBox.Name = "ScanCheckBox";
            this.ScanCheckBox.Size = new System.Drawing.Size(60, 60);
            this.ScanCheckBox.TabIndex = 16;
            this.ScanCheckBox.UseVisualStyleBackColor = true;
            this.ScanCheckBox.Click += new System.EventHandler(this.ScanCheckBox_Click);
            // 
            // SecurityCheckBox
            // 
            this.SecurityCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SecurityCheckBox.BackgroundImage = global::Virologie.Properties.Resources.Shield;
            this.SecurityCheckBox.Location = new System.Drawing.Point(30, 280);
            this.SecurityCheckBox.Name = "SecurityCheckBox";
            this.SecurityCheckBox.Size = new System.Drawing.Size(60, 60);
            this.SecurityCheckBox.TabIndex = 15;
            this.SecurityCheckBox.UseVisualStyleBackColor = true;
            this.SecurityCheckBox.Click += new System.EventHandler(this.SecurityCheckBox_Click);
            // 
            // HomeCheckBox
            // 
            this.HomeCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.HomeCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeCheckBox.BackgroundImage")));
            this.HomeCheckBox.Location = new System.Drawing.Point(30, 90);
            this.HomeCheckBox.Name = "HomeCheckBox";
            this.HomeCheckBox.Size = new System.Drawing.Size(60, 60);
            this.HomeCheckBox.TabIndex = 14;
            this.HomeCheckBox.UseVisualStyleBackColor = true;
            this.HomeCheckBox.Click += new System.EventHandler(this.HomeCheckBox_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Virologie.Properties.Resources.Logo;
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 9);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(50, 50);
            this.LogoPictureBox.TabIndex = 9;
            this.LogoPictureBox.TabStop = false;
            // 
            // groupBoxHome
            // 
            this.groupBoxHome.Location = new System.Drawing.Point(120, 70);
            this.groupBoxHome.Name = "groupBoxHome";
            this.groupBoxHome.Size = new System.Drawing.Size(653, 188);
            this.groupBoxHome.TabIndex = 19;
            // 
            // groupBoxScan1
            // 
            this.groupBoxScan1.Location = new System.Drawing.Point(120, 70);
            this.groupBoxScan1.Name = "groupBoxScan1";
            this.groupBoxScan1.Size = new System.Drawing.Size(680, 500);
            this.groupBoxScan1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 566);
            this.Controls.Add(this.groupBoxScan1);
            this.Controls.Add(this.groupBoxHome);
            this.Controls.Add(this.SettingsCheckBox);
            this.Controls.Add(this.UpdateCheckBox);
            this.Controls.Add(this.ScanCheckBox);
            this.Controls.Add(this.SecurityCheckBox);
            this.Controls.Add(this.HomeCheckBox);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.UpdateLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.StayProtectedLabel);
            this.Controls.Add(this.WindowsLabel);
            this.Controls.Add(this.WindowsTextBox);
            this.Controls.Add(this.SecurityLabel);
            this.Controls.Add(this.ScanLabel);
            this.Controls.Add(this.HomeLabel);
            this.Name = "Form1";
            this.Text = "Windows AntiVir Defender 2014";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Label ScanLabel;
        private System.Windows.Forms.Label SecurityLabel;
        private System.Windows.Forms.RichTextBox WindowsTextBox;
        private System.Windows.Forms.Label WindowsLabel;
        private System.Windows.Forms.Label StayProtectedLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label UpdateLabel;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.CheckBox HomeCheckBox;
        private System.Windows.Forms.CheckBox SecurityCheckBox;
        private System.Windows.Forms.CheckBox ScanCheckBox;
        private System.Windows.Forms.CheckBox UpdateCheckBox;
        private System.Windows.Forms.CheckBox SettingsCheckBox;
        private GroupBoxHome groupBoxHome;
        private GroupBoxScan groupBoxScan1;
    }
}

