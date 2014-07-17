namespace Virologie
{
    partial class GroupBoxUpdate
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
            this.UpdatePanel = new System.Windows.Forms.Panel();
            this.UpdateDisabledLabel = new System.Windows.Forms.Label();
            this.UpdateDescriptionLabel = new System.Windows.Forms.Label();
            this.OnCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateYesTextBox = new System.Windows.Forms.RichTextBox();
            this.OffCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateNoTextBox = new System.Windows.Forms.RichTextBox();
            this.ParametersPanel = new System.Windows.Forms.Panel();
            this.RedShieldPictureBox = new System.Windows.Forms.PictureBox();
            this.GreenShieldPictureBox = new System.Windows.Forms.PictureBox();
            this.UpdatePanel.SuspendLayout();
            this.ParametersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedShieldPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenShieldPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdatePanel
            // 
            this.UpdatePanel.BackColor = System.Drawing.Color.Red;
            this.UpdatePanel.Controls.Add(this.UpdateDisabledLabel);
            this.UpdatePanel.Location = new System.Drawing.Point(0, 20);
            this.UpdatePanel.Name = "UpdatePanel";
            this.UpdatePanel.Size = new System.Drawing.Size(650, 93);
            this.UpdatePanel.TabIndex = 0;
            // 
            // UpdateDisabledLabel
            // 
            this.UpdateDisabledLabel.AutoSize = true;
            this.UpdateDisabledLabel.BackColor = System.Drawing.Color.Red;
            this.UpdateDisabledLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDisabledLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateDisabledLabel.Location = new System.Drawing.Point(50, 34);
            this.UpdateDisabledLabel.Name = "UpdateDisabledLabel";
            this.UpdateDisabledLabel.Size = new System.Drawing.Size(547, 22);
            this.UpdateDisabledLabel.TabIndex = 22;
            this.UpdateDisabledLabel.Text = "Critical threat to your privacy : function Update is disabled";
            // 
            // UpdateDescriptionLabel
            // 
            this.UpdateDescriptionLabel.AutoSize = true;
            this.UpdateDescriptionLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDescriptionLabel.Location = new System.Drawing.Point(30, 127);
            this.UpdateDescriptionLabel.Name = "UpdateDescriptionLabel";
            this.UpdateDescriptionLabel.Size = new System.Drawing.Size(584, 16);
            this.UpdateDescriptionLabel.TabIndex = 1;
            this.UpdateDescriptionLabel.Text = "Automatic Update function is disabled. High risk of exposure to virus and malware" +
                "s on your system.";
            // 
            // OnCheckBox
            // 
            this.OnCheckBox.AutoSize = true;
            this.OnCheckBox.BackColor = System.Drawing.SystemColors.Window;
            this.OnCheckBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnCheckBox.Location = new System.Drawing.Point(161, 185);
            this.OnCheckBox.Name = "OnCheckBox";
            this.OnCheckBox.Size = new System.Drawing.Size(156, 21);
            this.OnCheckBox.TabIndex = 4;
            this.OnCheckBox.Text = "On (recommanded)";
            this.OnCheckBox.UseVisualStyleBackColor = false;
            this.OnCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckBox_CheckedChanged);
            // 
            // UpdateYesTextBox
            // 
            this.UpdateYesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpdateYesTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateYesTextBox.Location = new System.Drawing.Point(161, 209);
            this.UpdateYesTextBox.Name = "UpdateYesTextBox";
            this.UpdateYesTextBox.Size = new System.Drawing.Size(446, 61);
            this.UpdateYesTextBox.TabIndex = 5;
            this.UpdateYesTextBox.Text = "This function allow the program to perform automatic updating to raise your syste" +
                "m security level and protect from viruses and malicious spyware.\nNeeds the Premi" +
                "um version of the software.";
            // 
            // OffCheckBox
            // 
            this.OffCheckBox.AutoSize = true;
            this.OffCheckBox.BackColor = System.Drawing.SystemColors.Window;
            this.OffCheckBox.Checked = true;
            this.OffCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OffCheckBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffCheckBox.Location = new System.Drawing.Point(113, 117);
            this.OffCheckBox.Name = "OffCheckBox";
            this.OffCheckBox.Size = new System.Drawing.Size(130, 21);
            this.OffCheckBox.TabIndex = 6;
            this.OffCheckBox.Text = "Off (dangerous)";
            this.OffCheckBox.UseVisualStyleBackColor = false;
            this.OffCheckBox.Click += new System.EventHandler(this.OffCheckBox_Click);
            // 
            // UpdateNoTextBox
            // 
            this.UpdateNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpdateNoTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateNoTextBox.Location = new System.Drawing.Point(113, 144);
            this.UpdateNoTextBox.Name = "UpdateNoTextBox";
            this.UpdateNoTextBox.Size = new System.Drawing.Size(446, 51);
            this.UpdateNoTextBox.TabIndex = 7;
            this.UpdateNoTextBox.Text = "Your computer is under threat of being attacked by new viruses and malicious spyw" +
                "are.\nThe software can only partially protect you with this function.";
            // 
            // ParametersPanel
            // 
            this.ParametersPanel.BackColor = System.Drawing.SystemColors.Window;
            this.ParametersPanel.Controls.Add(this.UpdateNoTextBox);
            this.ParametersPanel.Controls.Add(this.OffCheckBox);
            this.ParametersPanel.Location = new System.Drawing.Point(48, 175);
            this.ParametersPanel.Name = "ParametersPanel";
            this.ParametersPanel.Size = new System.Drawing.Size(566, 215);
            this.ParametersPanel.TabIndex = 8;
            // 
            // RedShieldPictureBox
            // 
            this.RedShieldPictureBox.Image = global::Virologie.Properties.Resources.shield_red;
            this.RedShieldPictureBox.Location = new System.Drawing.Point(64, 292);
            this.RedShieldPictureBox.Name = "RedShieldPictureBox";
            this.RedShieldPictureBox.Size = new System.Drawing.Size(75, 75);
            this.RedShieldPictureBox.TabIndex = 3;
            this.RedShieldPictureBox.TabStop = false;
            // 
            // GreenShieldPictureBox
            // 
            this.GreenShieldPictureBox.Image = global::Virologie.Properties.Resources.shield_green;
            this.GreenShieldPictureBox.Location = new System.Drawing.Point(64, 185);
            this.GreenShieldPictureBox.Name = "GreenShieldPictureBox";
            this.GreenShieldPictureBox.Size = new System.Drawing.Size(75, 75);
            this.GreenShieldPictureBox.TabIndex = 2;
            this.GreenShieldPictureBox.TabStop = false;
            // 
            // GroupBoxUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdateYesTextBox);
            this.Controls.Add(this.OnCheckBox);
            this.Controls.Add(this.RedShieldPictureBox);
            this.Controls.Add(this.GreenShieldPictureBox);
            this.Controls.Add(this.UpdateDescriptionLabel);
            this.Controls.Add(this.UpdatePanel);
            this.Controls.Add(this.ParametersPanel);
            this.Name = "GroupBoxUpdate";
            this.Size = new System.Drawing.Size(680, 500);
            this.UpdatePanel.ResumeLayout(false);
            this.UpdatePanel.PerformLayout();
            this.ParametersPanel.ResumeLayout(false);
            this.ParametersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedShieldPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenShieldPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UpdatePanel;
        private System.Windows.Forms.Label UpdateDisabledLabel;
        private System.Windows.Forms.Label UpdateDescriptionLabel;
        private System.Windows.Forms.PictureBox GreenShieldPictureBox;
        private System.Windows.Forms.PictureBox RedShieldPictureBox;
        private System.Windows.Forms.CheckBox OnCheckBox;
        private System.Windows.Forms.RichTextBox UpdateYesTextBox;
        private System.Windows.Forms.CheckBox OffCheckBox;
        private System.Windows.Forms.RichTextBox UpdateNoTextBox;
        private System.Windows.Forms.Panel ParametersPanel;

    }
}
