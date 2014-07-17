namespace Virologie
{
    partial class GroupBoxScan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.VirusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Security = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StartScanButton = new System.Windows.Forms.Button();
            this.StopScanButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Logo,
            this.VirusName,
            this.Description,
            this.Security,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.FillWeight = 30F;
            this.Logo.HeaderText = "";
            this.Logo.Name = "Logo";
            this.Logo.ReadOnly = true;
            this.Logo.Width = 30;
            // 
            // VirusName
            // 
            this.VirusName.HeaderText = "Virus Name";
            this.VirusName.Name = "VirusName";
            this.VirusName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.FillWeight = 275F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 275;
            // 
            // Security
            // 
            this.Security.HeaderText = "Security";
            this.Security.Name = "Security";
            this.Security.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 375);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(637, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // StartScanButton
            // 
            this.StartScanButton.Location = new System.Drawing.Point(0, 20);
            this.StartScanButton.Name = "StartScanButton";
            this.StartScanButton.Size = new System.Drawing.Size(95, 23);
            this.StartScanButton.TabIndex = 2;
            this.StartScanButton.Text = "Start Scan";
            this.StartScanButton.UseVisualStyleBackColor = true;
            // 
            // StopScanButton
            // 
            this.StopScanButton.Location = new System.Drawing.Point(101, 20);
            this.StopScanButton.Name = "StopScanButton";
            this.StopScanButton.Size = new System.Drawing.Size(95, 23);
            this.StopScanButton.TabIndex = 3;
            this.StopScanButton.Text = "Stop Scan";
            this.StopScanButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove Viruses";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GroupBoxScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StopScanButton);
            this.Controls.Add(this.StartScanButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GroupBoxScan";
            this.Size = new System.Drawing.Size(680, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn Logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VirusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Security;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button StartScanButton;
        private System.Windows.Forms.Button StopScanButton;
        private System.Windows.Forms.Button button1;

    }
}
