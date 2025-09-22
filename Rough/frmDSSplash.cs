using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;

using System.IO.Ports;

namespace Rough
{
    public partial class frmDSSplash : Form
    {
        // public AxShockwaveFlashObjects.AxShockwaveFlash axFlash;
        public frmDSSplash()
        {

            InitializeComponent();
         




                    }
        #region Private Method
      
        #endregion
        private void tmSplash_Tick(object sender, EventArgs e)
        {
            tmSplash.Enabled = false;
            string strPath = Program.StartPath;
            if (File.Exists(strPath) == false)
            {
                frmDSConnectToServer frm = new frmDSConnectToServer();
                Program.Context.MainForm = frm;
                this.Close();
                frm.Show();
                return;
            }
            FileStream FS = new FileStream(strPath, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);
            //SysData.UMSConnectionStr = SysCryptography.EncryptDecryptStr(SR.ReadLine());
            BaseDb.ServerName = SR.ReadLine();
            BaseDb.DBName = SR.ReadLine();
            BaseDb.DBUser = SR.ReadLine();
            BaseDb.DBPassword = SR.ReadLine();
            SR.Close();
            FS.Close();
            BaseDb.RoughBaseDb = new BaseDb(BaseDb.ServerName, BaseDb.DBUser, BaseDb.DBPassword, BaseDb.DBName);




            frmDSDescisionSystem f = new frmDSDescisionSystem();
            f.ShowInTaskbar = true;

            Program.Context.MainForm = f;
            this.Close();
            f.Show();
        }
    
        public static ApplicationContext Context
        {
            set
            {
                Program.Context = value;
            }
        }

       

        private void frmDSSplash_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tmSplash_Tick(sender, e);
            }
        }
    }
}