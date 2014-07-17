namespace Virologie
{
    partial class GroupBoxHome
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.SystemLabel = new System.Windows.Forms.Label();
            this.LastScanLabel = new System.Windows.Forms.Label();
            this.ScanRedirectLabel = new System.Windows.Forms.LinkLabel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.VersionDateLabel = new System.Windows.Forms.Label();
            this.Check2PictureBox = new System.Windows.Forms.PictureBox();
            this.Check1PictureBox = new System.Windows.Forms.PictureBox();
            this.DangerPictureBox = new System.Windows.Forms.PictureBox();
            this.SoftwareLicenceLabel = new System.Windows.Forms.Label();
            this.FreeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.Check3PictureBox = new System.Windows.Forms.PictureBox();
            this.ScanLabel = new System.Windows.Forms.Label();
            this.NeverPerformedLabel = new System.Windows.Forms.Label();
            this.Check4PictureBox = new System.Windows.Forms.PictureBox();
            this.SoftwareVersionLabel = new System.Windows.Forms.Label();
            this.VersionValueLabel = new System.Windows.Forms.Label();
            this.UpdateSoftwareButton = new System.Windows.Forms.Button();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.ViralBasePanel = new System.Windows.Forms.Panel();
            this.SoftwareLicencePanel = new System.Windows.Forms.Panel();
            this.SoftwareVersionPanel = new System.Windows.Forms.Panel();
            this.LastScanPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Check2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DangerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check4PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SystemLabel
            // 
            this.SystemLabel.AutoSize = true;
            this.SystemLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.SystemLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SystemLabel.Location = new System.Drawing.Point(100, 45);
            this.SystemLabel.Name = "SystemLabel";
            this.SystemLabel.Size = new System.Drawing.Size(184, 22);
            this.SystemLabel.TabIndex = 21;
            this.SystemLabel.Text = "System in Danger !";
            // 
            // LastScanLabel
            // 
            this.LastScanLabel.AutoSize = true;
            this.LastScanLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.LastScanLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastScanLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LastScanLabel.Location = new System.Drawing.Point(100, 80);
            this.LastScanLabel.Name = "LastScanLabel";
            this.LastScanLabel.Size = new System.Drawing.Size(190, 16);
            this.LastScanLabel.TabIndex = 24;
            this.LastScanLabel.Text = "Last Scan : Never Performed";
            // 
            // ScanRedirectLabel
            // 
            this.ScanRedirectLabel.AutoSize = true;
            this.ScanRedirectLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.ScanRedirectLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanRedirectLabel.Location = new System.Drawing.Point(343, 60);
            this.ScanRedirectLabel.Name = "ScanRedirectLabel";
            this.ScanRedirectLabel.Size = new System.Drawing.Size(259, 16);
            this.ScanRedirectLabel.TabIndex = 25;
            this.ScanRedirectLabel.TabStop = true;
            this.ScanRedirectLabel.Text = "Click here to start scanning your system";
            this.ScanRedirectLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ScanRedirectLabel_LinkClicked);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.SystemColors.Window;
            this.VersionLabel.Location = new System.Drawing.Point(81, 157);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(99, 13);
            this.VersionLabel.TabIndex = 28;
            this.VersionLabel.Text = "Viral base version : ";
            // 
            // VersionDateLabel
            // 
            this.VersionDateLabel.AutoSize = true;
            this.VersionDateLabel.BackColor = System.Drawing.SystemColors.Window;
            this.VersionDateLabel.Location = new System.Drawing.Point(290, 157);
            this.VersionDateLabel.Name = "VersionDateLabel";
            this.VersionDateLabel.Size = new System.Drawing.Size(83, 13);
            this.VersionDateLabel.TabIndex = 29;
            this.VersionDateLabel.Text = "vDATE.HEURE";
            // 
            // Check2PictureBox
            // 
            this.Check2PictureBox.BackgroundImage = global::Virologie.Properties.Resources.Valide;
            this.Check2PictureBox.Image = global::Virologie.Properties.Resources.nTBXxd5zc;
            this.Check2PictureBox.Location = new System.Drawing.Point(22, 197);
            this.Check2PictureBox.Name = "Check2PictureBox";
            this.Check2PictureBox.Size = new System.Drawing.Size(30, 30);
            this.Check2PictureBox.TabIndex = 31;
            this.Check2PictureBox.TabStop = false;
            // 
            // Check1PictureBox
            // 
            this.Check1PictureBox.BackgroundImage = global::Virologie.Properties.Resources.Valide;
            this.Check1PictureBox.Location = new System.Drawing.Point(22, 149);
            this.Check1PictureBox.Name = "Check1PictureBox";
            this.Check1PictureBox.Size = new System.Drawing.Size(30, 30);
            this.Check1PictureBox.TabIndex = 27;
            this.Check1PictureBox.TabStop = false;
            // 
            // DangerPictureBox
            // 
            this.DangerPictureBox.BackgroundImage = global::Virologie.Properties.Resources.Danger;
            this.DangerPictureBox.Location = new System.Drawing.Point(22, 40);
            this.DangerPictureBox.Name = "DangerPictureBox";
            this.DangerPictureBox.Size = new System.Drawing.Size(60, 60);
            this.DangerPictureBox.TabIndex = 23;
            this.DangerPictureBox.TabStop = false;
            // 
            // SoftwareLicenceLabel
            // 
            this.SoftwareLicenceLabel.AutoSize = true;
            this.SoftwareLicenceLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SoftwareLicenceLabel.Location = new System.Drawing.Point(81, 205);
            this.SoftwareLicenceLabel.Name = "SoftwareLicenceLabel";
            this.SoftwareLicenceLabel.Size = new System.Drawing.Size(99, 13);
            this.SoftwareLicenceLabel.TabIndex = 32;
            this.SoftwareLicenceLabel.Text = "Software Licence : ";
            // 
            // FreeLinkLabel
            // 
            this.FreeLinkLabel.AutoSize = true;
            this.FreeLinkLabel.BackColor = System.Drawing.SystemColors.Window;
            this.FreeLinkLabel.Location = new System.Drawing.Point(290, 205);
            this.FreeLinkLabel.Name = "FreeLinkLabel";
            this.FreeLinkLabel.Size = new System.Drawing.Size(192, 13);
            this.FreeLinkLabel.TabIndex = 33;
            this.FreeLinkLabel.TabStop = true;
            this.FreeLinkLabel.Text = "Free (click here to upgrade to Premium)";
            this.FreeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Check3PictureBox
            // 
            this.Check3PictureBox.BackgroundImage = global::Virologie.Properties.Resources.Valide;
            this.Check3PictureBox.Image = global::Virologie.Properties.Resources.nTBXxd5zc;
            this.Check3PictureBox.Location = new System.Drawing.Point(22, 245);
            this.Check3PictureBox.Name = "Check3PictureBox";
            this.Check3PictureBox.Size = new System.Drawing.Size(30, 30);
            this.Check3PictureBox.TabIndex = 35;
            this.Check3PictureBox.TabStop = false;
            // 
            // ScanLabel
            // 
            this.ScanLabel.AutoSize = true;
            this.ScanLabel.BackColor = System.Drawing.SystemColors.Window;
            this.ScanLabel.Location = new System.Drawing.Point(81, 300);
            this.ScanLabel.Name = "ScanLabel";
            this.ScanLabel.Size = new System.Drawing.Size(64, 13);
            this.ScanLabel.TabIndex = 36;
            this.ScanLabel.Text = "Last Scan : ";
            // 
            // NeverPerformedLabel
            // 
            this.NeverPerformedLabel.AutoSize = true;
            this.NeverPerformedLabel.BackColor = System.Drawing.SystemColors.Window;
            this.NeverPerformedLabel.Location = new System.Drawing.Point(290, 300);
            this.NeverPerformedLabel.Name = "NeverPerformedLabel";
            this.NeverPerformedLabel.Size = new System.Drawing.Size(86, 13);
            this.NeverPerformedLabel.TabIndex = 37;
            this.NeverPerformedLabel.Text = "Never performed";
            // 
            // Check4PictureBox
            // 
            this.Check4PictureBox.BackgroundImage = global::Virologie.Properties.Resources.Valide;
            this.Check4PictureBox.Image = global::Virologie.Properties.Resources.nTBXxd5zc;
            this.Check4PictureBox.Location = new System.Drawing.Point(22, 293);
            this.Check4PictureBox.Name = "Check4PictureBox";
            this.Check4PictureBox.Size = new System.Drawing.Size(30, 30);
            this.Check4PictureBox.TabIndex = 39;
            this.Check4PictureBox.TabStop = false;
            // 
            // SoftwareVersionLabel
            // 
            this.SoftwareVersionLabel.AutoSize = true;
            this.SoftwareVersionLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SoftwareVersionLabel.Location = new System.Drawing.Point(81, 253);
            this.SoftwareVersionLabel.Name = "SoftwareVersionLabel";
            this.SoftwareVersionLabel.Size = new System.Drawing.Size(96, 13);
            this.SoftwareVersionLabel.TabIndex = 40;
            this.SoftwareVersionLabel.Text = "Software Version : ";
            // 
            // VersionValueLabel
            // 
            this.VersionValueLabel.AutoSize = true;
            this.VersionValueLabel.BackColor = System.Drawing.SystemColors.Window;
            this.VersionValueLabel.Location = new System.Drawing.Point(290, 253);
            this.VersionValueLabel.Name = "VersionValueLabel";
            this.VersionValueLabel.Size = new System.Drawing.Size(138, 13);
            this.VersionValueLabel.TabIndex = 41;
            this.VersionValueLabel.Text = "v1.14.8 (Upgrade available)";
            // 
            // UpdateSoftwareButton
            // 
            this.UpdateSoftwareButton.BackColor = System.Drawing.Color.Gold;
            this.UpdateSoftwareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSoftwareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSoftwareButton.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateSoftwareButton.Location = new System.Drawing.Point(0, 359);
            this.UpdateSoftwareButton.Name = "UpdateSoftwareButton";
            this.UpdateSoftwareButton.Size = new System.Drawing.Size(650, 93);
            this.UpdateSoftwareButton.TabIndex = 42;
            this.UpdateSoftwareButton.Text = "Click here to update your software to Premium version !";
            this.UpdateSoftwareButton.UseVisualStyleBackColor = false;
            this.UpdateSoftwareButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.DarkOrange;
            this.HomePanel.Location = new System.Drawing.Point(0, 20);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(650, 93);
            this.HomePanel.TabIndex = 43;
            // 
            // ViralBasePanel
            // 
            this.ViralBasePanel.BackColor = System.Drawing.SystemColors.Window;
            this.ViralBasePanel.Location = new System.Drawing.Point(0, 143);
            this.ViralBasePanel.Name = "ViralBasePanel";
            this.ViralBasePanel.Size = new System.Drawing.Size(650, 42);
            this.ViralBasePanel.TabIndex = 44;
            // 
            // SoftwareLicencePanel
            // 
            this.SoftwareLicencePanel.BackColor = System.Drawing.SystemColors.Window;
            this.SoftwareLicencePanel.Location = new System.Drawing.Point(0, 191);
            this.SoftwareLicencePanel.Name = "SoftwareLicencePanel";
            this.SoftwareLicencePanel.Size = new System.Drawing.Size(650, 42);
            this.SoftwareLicencePanel.TabIndex = 45;
            // 
            // SoftwareVersionPanel
            // 
            this.SoftwareVersionPanel.BackColor = System.Drawing.SystemColors.Window;
            this.SoftwareVersionPanel.Location = new System.Drawing.Point(0, 239);
            this.SoftwareVersionPanel.Name = "SoftwareVersionPanel";
            this.SoftwareVersionPanel.Size = new System.Drawing.Size(650, 42);
            this.SoftwareVersionPanel.TabIndex = 46;
            // 
            // LastScanPanel
            // 
            this.LastScanPanel.BackColor = System.Drawing.SystemColors.Window;
            this.LastScanPanel.Location = new System.Drawing.Point(0, 287);
            this.LastScanPanel.Name = "LastScanPanel";
            this.LastScanPanel.Size = new System.Drawing.Size(650, 42);
            this.LastScanPanel.TabIndex = 47;
            // 
            // GroupBoxHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdateSoftwareButton);
            this.Controls.Add(this.VersionValueLabel);
            this.Controls.Add(this.SoftwareVersionLabel);
            this.Controls.Add(this.Check4PictureBox);
            this.Controls.Add(this.NeverPerformedLabel);
            this.Controls.Add(this.ScanLabel);
            this.Controls.Add(this.Check3PictureBox);
            this.Controls.Add(this.FreeLinkLabel);
            this.Controls.Add(this.SoftwareLicenceLabel);
            this.Controls.Add(this.Check2PictureBox);
            this.Controls.Add(this.VersionDateLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.Check1PictureBox);
            this.Controls.Add(this.ScanRedirectLabel);
            this.Controls.Add(this.LastScanLabel);
            this.Controls.Add(this.DangerPictureBox);
            this.Controls.Add(this.SystemLabel);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.ViralBasePanel);
            this.Controls.Add(this.SoftwareLicencePanel);
            this.Controls.Add(this.SoftwareVersionPanel);
            this.Controls.Add(this.LastScanPanel);
            this.Name = "GroupBoxHome";
            this.Size = new System.Drawing.Size(680, 500);
            ((System.ComponentModel.ISupportInitialize)(this.Check2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DangerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check4PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SystemLabel;
        private System.Windows.Forms.PictureBox DangerPictureBox;
        private System.Windows.Forms.Label LastScanLabel;
        private System.Windows.Forms.LinkLabel ScanRedirectLabel;
        private System.Windows.Forms.PictureBox Check1PictureBox;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label VersionDateLabel;
        private System.Windows.Forms.PictureBox Check2PictureBox;
        private System.Windows.Forms.Label SoftwareLicenceLabel;
        private System.Windows.Forms.LinkLabel FreeLinkLabel;
        private System.Windows.Forms.PictureBox Check3PictureBox;
        private System.Windows.Forms.Label ScanLabel;
        private System.Windows.Forms.Label NeverPerformedLabel;
        private System.Windows.Forms.PictureBox Check4PictureBox;
        private System.Windows.Forms.Label SoftwareVersionLabel;
        private System.Windows.Forms.Label VersionValueLabel;
        private System.Windows.Forms.Button UpdateSoftwareButton;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Panel ViralBasePanel;
        private System.Windows.Forms.Panel SoftwareLicencePanel;
        private System.Windows.Forms.Panel SoftwareVersionPanel;
        private System.Windows.Forms.Panel LastScanPanel;
    }
}
