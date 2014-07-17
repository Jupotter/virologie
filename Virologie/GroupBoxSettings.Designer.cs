namespace Virologie
{
    partial class GroupBoxSettings
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
            this.LaunchCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateSoftwareButton = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.ExportCheckBox = new System.Windows.Forms.CheckBox();
            this.RecordsCheckBox = new System.Windows.Forms.CheckBox();
            this.RootkitsCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LaunchCheckBox
            // 
            this.LaunchCheckBox.AutoSize = true;
            this.LaunchCheckBox.Checked = true;
            this.LaunchCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LaunchCheckBox.Enabled = false;
            this.LaunchCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchCheckBox.Location = new System.Drawing.Point(10, 10);
            this.LaunchCheckBox.Name = "LaunchCheckBox";
            this.LaunchCheckBox.Size = new System.Drawing.Size(146, 19);
            this.LaunchCheckBox.TabIndex = 0;
            this.LaunchCheckBox.Text = "Launch with Windows";
            this.LaunchCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdateSoftwareButton
            // 
            this.UpdateSoftwareButton.BackColor = System.Drawing.Color.Gold;
            this.UpdateSoftwareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSoftwareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSoftwareButton.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateSoftwareButton.Location = new System.Drawing.Point(0, 20);
            this.UpdateSoftwareButton.Name = "UpdateSoftwareButton";
            this.UpdateSoftwareButton.Size = new System.Drawing.Size(650, 93);
            this.UpdateSoftwareButton.TabIndex = 37;
            this.UpdateSoftwareButton.Text = "Click here to update your software to Premium version !";
            this.UpdateSoftwareButton.UseVisualStyleBackColor = false;
            this.UpdateSoftwareButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.SettingsPanel.Controls.Add(this.ExportCheckBox);
            this.SettingsPanel.Controls.Add(this.RecordsCheckBox);
            this.SettingsPanel.Controls.Add(this.RootkitsCheckBox);
            this.SettingsPanel.Controls.Add(this.ShowCheckBox);
            this.SettingsPanel.Controls.Add(this.UpdateCheckBox);
            this.SettingsPanel.Controls.Add(this.LaunchCheckBox);
            this.SettingsPanel.Location = new System.Drawing.Point(60, 150);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(530, 154);
            this.SettingsPanel.TabIndex = 38;
            // 
            // ExportCheckBox
            // 
            this.ExportCheckBox.AutoSize = true;
            this.ExportCheckBox.Checked = true;
            this.ExportCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExportCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportCheckBox.Location = new System.Drawing.Point(10, 125);
            this.ExportCheckBox.Name = "ExportCheckBox";
            this.ExportCheckBox.Size = new System.Drawing.Size(320, 19);
            this.ExportCheckBox.TabIndex = 5;
            this.ExportCheckBox.Text = "Advanced : export information from the logs to the disk";
            this.ExportCheckBox.UseVisualStyleBackColor = true;
            // 
            // RecordsCheckBox
            // 
            this.RecordsCheckBox.AutoSize = true;
            this.RecordsCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsCheckBox.Location = new System.Drawing.Point(10, 102);
            this.RecordsCheckBox.Name = "RecordsCheckBox";
            this.RecordsCheckBox.Size = new System.Drawing.Size(230, 19);
            this.RecordsCheckBox.TabIndex = 4;
            this.RecordsCheckBox.Text = "Advanced : check for records (slower)";
            this.RecordsCheckBox.UseVisualStyleBackColor = true;
            // 
            // RootkitsCheckBox
            // 
            this.RootkitsCheckBox.AutoSize = true;
            this.RootkitsCheckBox.Checked = true;
            this.RootkitsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RootkitsCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RootkitsCheckBox.Location = new System.Drawing.Point(10, 79);
            this.RootkitsCheckBox.Name = "RootkitsCheckBox";
            this.RootkitsCheckBox.Size = new System.Drawing.Size(186, 19);
            this.RootkitsCheckBox.TabIndex = 3;
            this.RootkitsCheckBox.Text = "Advanced : search for rootkits";
            this.RootkitsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowCheckBox
            // 
            this.ShowCheckBox.AutoSize = true;
            this.ShowCheckBox.Checked = true;
            this.ShowCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCheckBox.Location = new System.Drawing.Point(10, 56);
            this.ShowCheckBox.Name = "ShowCheckBox";
            this.ShowCheckBox.Size = new System.Drawing.Size(126, 19);
            this.ShowCheckBox.TabIndex = 2;
            this.ShowCheckBox.Text = "Show notifications";
            this.ShowCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdateCheckBox
            // 
            this.UpdateCheckBox.AutoSize = true;
            this.UpdateCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCheckBox.Location = new System.Drawing.Point(10, 33);
            this.UpdateCheckBox.Name = "UpdateCheckBox";
            this.UpdateCheckBox.Size = new System.Drawing.Size(209, 19);
            this.UpdateCheckBox.TabIndex = 1;
            this.UpdateCheckBox.Text = "Automatically update the software";
            this.UpdateCheckBox.UseVisualStyleBackColor = true;
            this.UpdateCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // RestoreButton
            // 
            this.RestoreButton.Location = new System.Drawing.Point(70, 315);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(152, 23);
            this.RestoreButton.TabIndex = 39;
            this.RestoreButton.Text = "Restore default parameters";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(486, 315);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 23);
            this.SaveButton.TabIndex = 40;
            this.SaveButton.Text = "Save changes";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RestoreButton);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.UpdateSoftwareButton);
            this.Name = "GroupBoxSettings";
            this.Size = new System.Drawing.Size(680, 500);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox LaunchCheckBox;
        private System.Windows.Forms.Button UpdateSoftwareButton;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.CheckBox ShowCheckBox;
        private System.Windows.Forms.CheckBox UpdateCheckBox;
        private System.Windows.Forms.CheckBox ExportCheckBox;
        private System.Windows.Forms.CheckBox RecordsCheckBox;
        private System.Windows.Forms.CheckBox RootkitsCheckBox;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.Button SaveButton;

    }
}
