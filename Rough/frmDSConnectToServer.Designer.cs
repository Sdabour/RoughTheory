namespace Rough
{
    partial class frmDSConnectToServer
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
            this.btnCheckSharpCon = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckSharpCon
            // 
            this.btnCheckSharpCon.Location = new System.Drawing.Point(395, 150);
            this.btnCheckSharpCon.Name = "btnCheckSharpCon";
            this.btnCheckSharpCon.Size = new System.Drawing.Size(107, 32);
            this.btnCheckSharpCon.TabIndex = 42;
            this.btnCheckSharpCon.Text = "Check Connection";
            this.btnCheckSharpCon.UseVisualStyleBackColor = true;
            this.btnCheckSharpCon.Click += new System.EventHandler(this.btnCheckSharpCon_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 150);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(303, 20);
            this.txtPassword.TabIndex = 41;
            this.txtPassword.Text = "Permanent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 153);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "DbPassword";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(83, 109);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserID.Size = new System.Drawing.Size(303, 20);
            this.txtUserID.TabIndex = 39;
            this.txtUserID.Text = "Permanent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "DbUserID";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(84, 26);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServerName.Size = new System.Drawing.Size(303, 20);
            this.txtServerName.TabIndex = 37;
            this.txtServerName.Text = "10.0.0.90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "ServerName";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(281, 191);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(124, 191);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 32);
            this.btnEnter.TabIndex = 43;
            this.btnEnter.Text = "Log In";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(83, 68);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDbName.Size = new System.Drawing.Size(303, 20);
            this.txtDbName.TabIndex = 46;
            this.txtDbName.Text = "RoughDb";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "DbName";
            // 
            // frmDSConnectToServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 236);
            this.Controls.Add(this.txtDbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnCheckSharpCon);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label5);
            this.Name = "frmDSConnectToServer";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect To Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckSharpCon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Label label1;
    }
}