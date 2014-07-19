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
            this.WindowsLabel = new System.Windows.Forms.Label();
            this.StayProtectedLabel = new System.Windows.Forms.Label();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.SupportButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.SettingsCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.ScanCheckBox = new System.Windows.Forms.CheckBox();
            this.SecurityCheckBox = new System.Windows.Forms.CheckBox();
            this.HomeCheckBox = new System.Windows.Forms.CheckBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.WindowsPanel = new System.Windows.Forms.Panel();
            this.groupBoxHome = new Virologie.GroupBoxHome();
            this.groupBoxSettings1 = new Virologie.GroupBoxSettings();
            this.groupBoxUpdate1 = new Virologie.GroupBoxUpdate();
            this.groupBoxSecurity = new Virologie.GroupBoxSecurity();
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
            this.ScanLabel.Location = new System.Drawing.Point(45, 248);
            this.ScanLabel.Name = "ScanLabel";
            this.ScanLabel.Size = new System.Drawing.Size(32, 13);
            this.ScanLabel.TabIndex = 3;
            this.ScanLabel.Text = "Scan";
            // 
            // SecurityLabel
            // 
            this.SecurityLabel.AutoSize = true;
            this.SecurityLabel.Location = new System.Drawing.Point(38, 343);
            this.SecurityLabel.Name = "SecurityLabel";
            this.SecurityLabel.Size = new System.Drawing.Size(45, 13);
            this.SecurityLabel.TabIndex = 5;
            this.SecurityLabel.Text = "Security";
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
            this.UpdateLabel.Location = new System.Drawing.Point(40, 438);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(42, 13);
            this.UpdateLabel.TabIndex = 11;
            this.UpdateLabel.Text = "Update";
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Location = new System.Drawing.Point(38, 533);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(45, 13);
            this.SettingsLabel.TabIndex = 13;
            this.SettingsLabel.Text = "Settings";
            // 
            // SupportButton
            // 
            this.SupportButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SupportButton.FlatAppearance.BorderSize = 2;
            this.SupportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupportButton.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupportButton.ForeColor = System.Drawing.Color.Gold;
            this.SupportButton.Image = ((System.Drawing.Image)(resources.GetObject("SupportButton.Image")));
            this.SupportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SupportButton.Location = new System.Drawing.Point(615, 0);
            this.SupportButton.Name = "SupportButton";
            this.SupportButton.Size = new System.Drawing.Size(183, 70);
            this.SupportButton.TabIndex = 26;
            this.SupportButton.Text = "Support    ";
            this.SupportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SupportButton.UseVisualStyleBackColor = false;
            this.SupportButton.Click += new System.EventHandler(this.SupportButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RegistrationButton.FlatAppearance.BorderSize = 2;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationButton.ForeColor = System.Drawing.Color.Gold;
            this.RegistrationButton.Image = global::Virologie.Properties.Resources.lock_clipart_RcA6kE5Xi_000;
            this.RegistrationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistrationButton.Location = new System.Drawing.Point(433, 0);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(183, 70);
            this.RegistrationButton.TabIndex = 25;
            this.RegistrationButton.Text = "Registration";
            this.RegistrationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
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
            // WindowsPanel
            // 
            this.WindowsPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.WindowsPanel.Location = new System.Drawing.Point(0, 0);
            this.WindowsPanel.Name = "WindowsPanel";
            this.WindowsPanel.Size = new System.Drawing.Size(800, 70);
            this.WindowsPanel.TabIndex = 27;
            // 
            // groupBoxHome
            // 
            this.groupBoxHome.AutoSize = true;
            this.groupBoxHome.Location = new System.Drawing.Point(120, 70);
            this.groupBoxHome.Name = "groupBoxHome";
            this.groupBoxHome.Size = new System.Drawing.Size(653, 457);
            this.groupBoxHome.TabIndex = 24;
            // 
            // groupBoxSettings1
            // 
            this.groupBoxSettings1.Location = new System.Drawing.Point(120, 70);
            this.groupBoxSettings1.Name = "groupBoxSettings1";
            this.groupBoxSettings1.Size = new System.Drawing.Size(680, 500);
            this.groupBoxSettings1.TabIndex = 23;
            // 
            // groupBoxUpdate1
            // 
            this.groupBoxUpdate1.Location = new System.Drawing.Point(120, 70);
            this.groupBoxUpdate1.Name = "groupBoxUpdate1";
            this.groupBoxUpdate1.Size = new System.Drawing.Size(680, 500);
            this.groupBoxUpdate1.TabIndex = 22;
            // 
            // groupBoxSecurity
            // 
            this.groupBoxSecurity.AutoSize = true;
            this.groupBoxSecurity.Location = new System.Drawing.Point(120, 70);
            this.groupBoxSecurity.Name = "groupBoxSecurity";
            this.groupBoxSecurity.Size = new System.Drawing.Size(680, 500);
            this.groupBoxSecurity.TabIndex = 21;
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
            this.Controls.Add(this.SupportButton);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.groupBoxHome);
            this.Controls.Add(this.groupBoxSettings1);
            this.Controls.Add(this.groupBoxUpdate1);
            this.Controls.Add(this.groupBoxSecurity);
            this.Controls.Add(this.groupBoxScan1);
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
            this.Controls.Add(this.SecurityLabel);
            this.Controls.Add(this.ScanLabel);
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.WindowsPanel);
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
        private GroupBoxScan groupBoxScan1;
        private GroupBoxSecurity groupBoxSecurity;
        private GroupBoxUpdate groupBoxUpdate1;
        private GroupBoxSettings groupBoxSettings1;
        private GroupBoxHome groupBoxHome;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button SupportButton;
        private System.Windows.Forms.Panel WindowsPanel;
    }
}

