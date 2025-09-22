namespace Rough
{
    partial class frmDSDescisionSystem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDecisionMatrix = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setDataConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAttributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discrenibilityMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSQLConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveDecisionMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdDecisionMatrix)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDecisionMatrix
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDecisionMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdDecisionMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDecisionMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDecisionMatrix.DefaultCellStyle = dataGridViewCellStyle9;
            this.grdDecisionMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDecisionMatrix.Location = new System.Drawing.Point(0, 24);
            this.grdDecisionMatrix.Name = "grdDecisionMatrix";
            this.grdDecisionMatrix.Size = new System.Drawing.Size(817, 534);
            this.grdDecisionMatrix.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDataConnectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setDataConnectionToolStripMenuItem
            // 
            this.setDataConnectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAttributeToolStripMenuItem,
            this.saveDecisionMatrixToolStripMenuItem,
            this.discrenibilityMatrixToolStripMenuItem,
            this.setSQLConnectionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.setDataConnectionToolStripMenuItem.Name = "setDataConnectionToolStripMenuItem";
            this.setDataConnectionToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.setDataConnectionToolStripMenuItem.Text = "Main Data";
            // 
            // setAttributeToolStripMenuItem
            // 
            this.setAttributeToolStripMenuItem.Name = "setAttributeToolStripMenuItem";
            this.setAttributeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.setAttributeToolStripMenuItem.Text = "Set Attribute";
            this.setAttributeToolStripMenuItem.Click += new System.EventHandler(this.setAttributeToolStripMenuItem_Click);
            // 
            // discrenibilityMatrixToolStripMenuItem
            // 
            this.discrenibilityMatrixToolStripMenuItem.Name = "discrenibilityMatrixToolStripMenuItem";
            this.discrenibilityMatrixToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.discrenibilityMatrixToolStripMenuItem.Text = "Discrenibility Matrix";
            this.discrenibilityMatrixToolStripMenuItem.Click += new System.EventHandler(this.discrenibilityMatrixToolStripMenuItem_Click);
            // 
            // setSQLConnectionToolStripMenuItem
            // 
            this.setSQLConnectionToolStripMenuItem.Name = "setSQLConnectionToolStripMenuItem";
            this.setSQLConnectionToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.setSQLConnectionToolStripMenuItem.Text = "Set SQL Connection";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ShortName";
            this.Column2.Name = "Column2";
            // 
            // saveDecisionMatrixToolStripMenuItem
            // 
            this.saveDecisionMatrixToolStripMenuItem.Name = "saveDecisionMatrixToolStripMenuItem";
            this.saveDecisionMatrixToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.saveDecisionMatrixToolStripMenuItem.Text = "Save Decision Matrix";
            this.saveDecisionMatrixToolStripMenuItem.Click += new System.EventHandler(this.saveDecisionMatrixToolStripMenuItem_Click);
            // 
            // frmDSDescisionSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(817, 558);
            this.Controls.Add(this.grdDecisionMatrix);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmDSDescisionSystem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decision System";
            ((System.ComponentModel.ISupportInitialize)(this.grdDecisionMatrix)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDecisionMatrix;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setDataConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAttributeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSQLConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discrenibilityMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripMenuItem saveDecisionMatrixToolStripMenuItem;
    }
}

