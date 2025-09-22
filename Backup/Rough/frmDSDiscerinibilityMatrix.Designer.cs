namespace Rough
{
    partial class frmDSDiscerinibilityMatrix
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdMatrix = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDecisionAttribute = new System.Windows.Forms.Label();
            this.cmbDecisionAttributeValue = new System.Windows.Forms.ComboBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReducts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMatrix
            // 
            this.grdMatrix.AllowUserToAddRows = false;
            this.grdMatrix.AllowUserToDeleteRows = false;
            this.grdMatrix.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMatrix.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdMatrix.Location = new System.Drawing.Point(-4, 73);
            this.grdMatrix.Name = "grdMatrix";
            this.grdMatrix.ReadOnly = true;
            this.grdMatrix.RowHeadersWidth = 80;
            this.grdMatrix.Size = new System.Drawing.Size(895, 499);
            this.grdMatrix.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(-4, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDecisionAttribute
            // 
            this.lblDecisionAttribute.AutoSize = true;
            this.lblDecisionAttribute.Location = new System.Drawing.Point(181, 15);
            this.lblDecisionAttribute.Name = "lblDecisionAttribute";
            this.lblDecisionAttribute.Size = new System.Drawing.Size(46, 13);
            this.lblDecisionAttribute.TabIndex = 13;
            this.lblDecisionAttribute.Text = "Decision";
            // 
            // cmbDecisionAttributeValue
            // 
            this.cmbDecisionAttributeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDecisionAttributeValue.FormattingEnabled = true;
            this.cmbDecisionAttributeValue.Location = new System.Drawing.Point(275, 12);
            this.cmbDecisionAttributeValue.Name = "cmbDecisionAttributeValue";
            this.cmbDecisionAttributeValue.Size = new System.Drawing.Size(205, 21);
            this.cmbDecisionAttributeValue.TabIndex = 14;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(486, 7);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 29);
            this.btnFill.TabIndex = 15;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Reducts";
            // 
            // lblReducts
            // 
            this.lblReducts.AutoSize = true;
            this.lblReducts.Location = new System.Drawing.Point(281, 47);
            this.lblReducts.Name = "lblReducts";
            this.lblReducts.Size = new System.Drawing.Size(11, 13);
            this.lblReducts.TabIndex = 17;
            this.lblReducts.Text = "|";
            // 
            // frmDSDiscerinibilityMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 567);
            this.Controls.Add(this.lblReducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.cmbDecisionAttributeValue);
            this.Controls.Add(this.lblDecisionAttribute);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grdMatrix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmDSDiscerinibilityMatrix";
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discernibility Matrix";
            ((System.ComponentModel.ISupportInitialize)(this.grdMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMatrix;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDecisionAttribute;
        private System.Windows.Forms.ComboBox cmbDecisionAttributeValue;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReducts;
    }
}