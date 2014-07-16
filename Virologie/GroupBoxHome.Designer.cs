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
            this.WarningTextBox = new System.Windows.Forms.RichTextBox();
            this.SystemLabel = new System.Windows.Forms.Label();
            this.DangerPictureBox = new System.Windows.Forms.PictureBox();
            this.LastScanLabel = new System.Windows.Forms.Label();
            this.ScanRedirectLabel = new System.Windows.Forms.LinkLabel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Check1PictureBox = new System.Windows.Forms.PictureBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.VersionDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DangerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WarningTextBox
            // 
            this.WarningTextBox.BackColor = System.Drawing.Color.DarkOrange;
            this.WarningTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarningTextBox.Location = new System.Drawing.Point(0, 22);
            this.WarningTextBox.Name = "WarningTextBox";
            this.WarningTextBox.Size = new System.Drawing.Size(650, 93);
            this.WarningTextBox.TabIndex = 20;
            this.WarningTextBox.Text = "";
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
            // DangerPictureBox
            // 
            this.DangerPictureBox.BackgroundImage = global::Virologie.Properties.Resources.Danger;
            this.DangerPictureBox.Location = new System.Drawing.Point(22, 40);
            this.DangerPictureBox.Name = "DangerPictureBox";
            this.DangerPictureBox.Size = new System.Drawing.Size(60, 60);
            this.DangerPictureBox.TabIndex = 23;
            this.DangerPictureBox.TabStop = false;
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
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(0, 143);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(650, 42);
            this.richTextBox2.TabIndex = 26;
            this.richTextBox2.Text = "";
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
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.SystemColors.Window;
            this.VersionLabel.Location = new System.Drawing.Point(81, 157);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(159, 13);
            this.VersionLabel.TabIndex = 28;
            this.VersionLabel.Text = "Version de la base de données :";
            // 
            // VersionDateLabel
            // 
            this.VersionDateLabel.AutoSize = true;
            this.VersionDateLabel.BackColor = System.Drawing.SystemColors.Window;
            this.VersionDateLabel.Location = new System.Drawing.Point(343, 157);
            this.VersionDateLabel.Name = "VersionDateLabel";
            this.VersionDateLabel.Size = new System.Drawing.Size(83, 13);
            this.VersionDateLabel.TabIndex = 29;
            this.VersionDateLabel.Text = "vDATE.HEURE";
            // 
            // GroupBoxHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VersionDateLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.Check1PictureBox);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.ScanRedirectLabel);
            this.Controls.Add(this.LastScanLabel);
            this.Controls.Add(this.DangerPictureBox);
            this.Controls.Add(this.SystemLabel);
            this.Controls.Add(this.WarningTextBox);
            this.Name = "GroupBoxHome";
            this.Size = new System.Drawing.Size(680, 500);
            ((System.ComponentModel.ISupportInitialize)(this.DangerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox WarningTextBox;
        private System.Windows.Forms.Label SystemLabel;
        private System.Windows.Forms.PictureBox DangerPictureBox;
        private System.Windows.Forms.Label LastScanLabel;
        private System.Windows.Forms.LinkLabel ScanRedirectLabel;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox Check1PictureBox;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label VersionDateLabel;
    }
}
