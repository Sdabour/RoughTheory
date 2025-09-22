using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rough
{
    public partial class frmDSDescisionSystem : Form
    {
        #region Private Data
        #endregion
        public frmDSDescisionSystem()
        {
            InitializeComponent();
            InitializeDecisionMatrix();
            SetData();
        }
        #region Private Method
        void InitializeDecisionMatrix()
        {
            grdDecisionMatrix.Columns.Clear();
            DataGridViewColumn objColumn = new DataGridViewColumn();
             DataGridViewCell objCell = new  DataGridViewTextBoxCell();
            objColumn.Name = "ClName";
            objColumn.HeaderText = "Name";
            objColumn.CellTemplate = objCell;
           
            grdDecisionMatrix.Columns.Add(objColumn);
            objColumn = new DataGridViewColumn();
            objColumn.Name = "ClShortName";
            objColumn.HeaderText = "Short Name";
            objColumn.CellTemplate = objCell;
            grdDecisionMatrix.Columns.Add(objColumn);
            int intIndex = 0;
            foreach (AttributeBiz objBiz in AttributeBiz.AttributeLst)
            {
                intIndex++;
                objCell = new DataGridViewComboBoxCell();
                objColumn = new DataGridViewComboBoxColumn();
                objColumn.Name = "Attribute"+intIndex.ToString();
                objColumn.HeaderText = objBiz.DisplayName;
                objColumn.CellTemplate = objCell;
                ((DataGridViewComboBoxColumn)objColumn).DataSource = objBiz.DisplayValueLst;
                ((DataGridViewComboBoxColumn)objColumn).DisplayMember = "Value";
                grdDecisionMatrix.Columns.Add(objColumn);
            }
        }
        void SetData()
        {
            grdDecisionMatrix.Rows.Clear();
            DataGridViewRow objDr;
            int intIndex = 0;
           
            foreach (UniversalObjectBiz objBiz in UniversalObjectBiz.UniverseObjectLst)
            {
                grdDecisionMatrix.Rows.Add();
                objDr = grdDecisionMatrix.Rows[intIndex];
                intIndex++;
                objDr.Cells[0].Value = objBiz.Name;
                objDr.Cells[1].Value = objBiz.ShortName;
                for (int intColumnIndex = 0; intColumnIndex < objBiz.ValueLst.Count; intColumnIndex++)
                {
                    objDr.Cells[intColumnIndex + 2].Value = objBiz.ValueLst[intColumnIndex].Value;
                }
                
            }
        }
        void GetData()
        {
            UniversalObjectBiz.UniverseObjectLst = new List<UniversalObjectBiz>();
            UniversalObjectBiz objBiz;
            UniversalObjectValueBiz objValueBiz;
            int intColumnIndex = 2;
            foreach (DataGridViewRow objDr in grdDecisionMatrix.Rows)
            {
                if (objDr.IsNewRow || objDr.Cells[0].Value == null ||
                    objDr.Cells[0].Value.ToString() == "")
                    continue;
                objBiz = new UniversalObjectBiz();
                objBiz.Name = objDr.Cells[0].Value == null ? "" : objDr.Cells[0].Value.ToString();
                objBiz.ShortName = objDr.Cells[1].Value == null ?"" : objDr.Cells[1].Value.ToString();
                intColumnIndex = 2;
                foreach (AttributeBiz objAttributeBiz in AttributeBiz.AttributeLst)
                {
                    objValueBiz = new UniversalObjectValueBiz();
                    objValueBiz.AttributeBiz = objAttributeBiz;
                    objValueBiz.AttributeID = objAttributeBiz.ID;
                    objValueBiz.Value = objDr.Cells.Count > intColumnIndex &&
                        objDr.Cells[intColumnIndex].Value != null&&
                        objDr.Cells[intColumnIndex].Value.ToString() != "" ?
                        objDr.Cells[intColumnIndex].Value.ToString() : "";
                    objBiz.ValueLst.Add(objValueBiz);
                    intColumnIndex++;
                }
                UniversalObjectBiz.UniverseObjectLst.Add(objBiz);
            }
        }
        #endregion
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setAttributeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSAttribute frm = new frmDSAttribute();
            frm.ShowDialog();
            //UniversalObjectBiz.UniverseObjectLst = null;
            InitializeDecisionMatrix();
            SetData();

        }

        private void saveDecisionMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetData();
            UniversalObjectBiz.JoinDecisionTable();


        }

        private void discrenibilityMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSDiscerinibilityMatrix frm = new frmDSDiscerinibilityMatrix();
            frm.ShowDialog();
        }
    }
}