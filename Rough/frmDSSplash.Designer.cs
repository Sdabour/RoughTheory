

namespace Rough
{
    partial class frmDSSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSSplash));
           
            this.tmSplash = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // axFl
            // 
            // tmSplash
            // 
            this.tmSplash.Enabled = true;
            this.tmSplash.Interval = 10;
            this.tmSplash.Tick += new System.EventHandler(this.tmSplash_Tick);
            // 
            // frmDSSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 548);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDSSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.tmSplash_Tick);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmDSSplash_KeyUp);
            
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmSplash;
    }
}