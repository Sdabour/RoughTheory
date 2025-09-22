using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Rough
{
    public partial class frmDSConnectToServer : Form
    {
        public frmDSConnectToServer()
        {
            InitializeComponent();
            string strPath = Program.StartPath;
            if (File.Exists(strPath) == true)
            {

                FileStream FS = new FileStream(strPath, FileMode.Open, FileAccess.Read);
                StreamReader SR = new StreamReader(FS);
                //SysData.UMSConnectionStr = SysCryptography.EncryptDecryptStr(SR.ReadLine());
                BaseDb.ServerName = SR.ReadLine();
                BaseDb.DBName = SR.ReadLine();
                BaseDb.DBUser = SR.ReadLine();
                BaseDb.DBPassword = SR.ReadLine();
                SR.Close();
                FS.Close();
                txtServerName.Text = BaseDb.ServerName;
                txtDbName.Text = BaseDb.DBName;
                txtUserID.Text = BaseDb.DBUser;
                txtPassword.Text = BaseDb.DBPassword;

            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string strPath = Program.StartPath;


            if (File.Exists(strPath) == true)
            {
                File.Delete(strPath);
            }

            if (txtServerName.Text == "")
            {
                MessageBox.Show("„‰ ›÷·ﬂ Õœœ «”„ Œ«œ„ «·»Ì«‰« ");
                return;
            }


            //  SysData.UMSConnectionStr = txtUMSConnection.Text;
            BaseDb.ServerName = txtServerName.Text;
            BaseDb.DBName = txtDbName.Text;
            BaseDb.DBUser = txtUserID.Text;
            BaseDb.DBPassword = txtPassword.Text;
            BaseDb objTemp = new BaseDb(BaseDb.ServerName, BaseDb.DBUser, BaseDb.DBPassword,BaseDb.DBName);

            if (objTemp.sqlConnection.TestConection() == false)
            {
                MessageBox.Show("›‘· ›Ï «·√ ’«· »ﬁ«⁄œ… «·»«Ì«‰«  ");
                return;
            }

            BaseDb.RoughBaseDb = new BaseDb(BaseDb.ServerName, BaseDb.DBUser, BaseDb.DBPassword, BaseDb.DBName);
          
            StreamWriter SW;
            FileStream FS = new FileStream(strPath, FileMode.Create, FileAccess.Write);
            SW = new StreamWriter(FS);
            SW.WriteLine(BaseDb.ServerName);
            SW.WriteLine(BaseDb.DBName);
            SW.WriteLine(BaseDb.DBUser);
            SW.WriteLine(BaseDb.DBPassword);
            
            SW.Close();
            FS.Close();

            frmDSDescisionSystem f = new frmDSDescisionSystem();
            f.ShowInTaskbar = true;

            Program.Context.MainForm = f;
            this.Close();
            f.Show();
        }

        private void btnCheckSharpCon_Click(object sender, EventArgs e)
        {
            BaseDb objTemp = new BaseDb(BaseDb.ServerName, BaseDb.DBUser, BaseDb.DBPassword, BaseDb.DBName);

            if (objTemp.sqlConnection.TestConection() == false)
            {
                MessageBox.Show("›‘· ›Ï «·√ ’«· »ﬁ«⁄œ… «·»«Ì«‰«  ");
                return;
            }
            else
                MessageBox.Show(" „ «·« ’«· »‰Ã«Õ");
        }
    }
}