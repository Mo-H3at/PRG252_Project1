namespace PRG252_Project
{
    partial class FrmBaseCamp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseCamp));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBaseCamp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewJetModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeJetModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateJetModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLaunch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseCamp)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Camp";
            // 
            // dgvBaseCamp
            // 
            this.dgvBaseCamp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseCamp.Location = new System.Drawing.Point(530, 113);
            this.dgvBaseCamp.Name = "dgvBaseCamp";
            this.dgvBaseCamp.Size = new System.Drawing.Size(349, 197);
            this.dgvBaseCamp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available Jets";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertNewJetModelToolStripMenuItem,
            this.removeJetModelToolStripMenuItem,
            this.updateJetModelToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // insertNewJetModelToolStripMenuItem
            // 
            this.insertNewJetModelToolStripMenuItem.Name = "insertNewJetModelToolStripMenuItem";
            this.insertNewJetModelToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.insertNewJetModelToolStripMenuItem.Text = "Insert new jet model";
            // 
            // removeJetModelToolStripMenuItem
            // 
            this.removeJetModelToolStripMenuItem.Name = "removeJetModelToolStripMenuItem";
            this.removeJetModelToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.removeJetModelToolStripMenuItem.Text = "Remove jet model";
            // 
            // updateJetModelToolStripMenuItem
            // 
            this.updateJetModelToolStripMenuItem.Name = "updateJetModelToolStripMenuItem";
            this.updateJetModelToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.updateJetModelToolStripMenuItem.Text = "Update jet model";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReportToolStripMenuItem,
            this.deleteReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // viewReportToolStripMenuItem
            // 
            this.viewReportToolStripMenuItem.Name = "viewReportToolStripMenuItem";
            this.viewReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewReportToolStripMenuItem.Text = "View Report";
            // 
            // deleteReportToolStripMenuItem
            // 
            this.deleteReportToolStripMenuItem.Name = "deleteReportToolStripMenuItem";
            this.deleteReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteReportToolStripMenuItem.Text = "Delete Report";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(601, 316);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(204, 23);
            this.btnLaunch.TabIndex = 4;
            this.btnLaunch.Text = "Launch Simulation";
            this.btnLaunch.UseVisualStyleBackColor = true;
            // 
            // FrmBaseCamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 498);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBaseCamp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBaseCamp";
            this.Text = "Base Camp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseCamp)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBaseCamp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertNewJetModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeJetModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateJetModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteReportToolStripMenuItem;
        private System.Windows.Forms.Button btnLaunch;
    }
}

