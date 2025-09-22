using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rough
{
    public partial class frmDSDiscerinibilityMatrix : Form
    {
        public frmDSDiscerinibilityMatrix()
        {
            InitializeComponent();
            lblDecisionAttribute.Text = AttributeBiz.DecisionAttribute.ID != 0 ?
                AttributeBiz.DecisionAttribute.DisplayName : lblDecisionAttribute.Text;
            FillDecisonAttributeValueCmb();

        }
        #region Private Method
        void FillDecisonAttributeValueCmb()
        {
            if (AttributeBiz.DecisionAttribute.ID == 0)
                return;
            cmbDecisionAttributeValue.DataSource = AttributeBiz.DecisionAttribute.DisplayValueLst;
            cmbDecisionAttributeValue.DisplayMember = "Value";
           
        }
        void FillDicrenibilityMatrix()
        {
            grdMatrix.Columns.Clear();
            DataGridViewColumn objColumn = new DataGridViewColumn();
            DataGridViewCell objCell = new DataGridViewTextBoxCell();
            DataGridViewRow objDr;
            grdMatrix.Rows.Clear();
            List<UniversalObjectBiz> objUniversalObjectColumnLst = UniversalObjectBiz.GetUniversalObjectByDecision(cmbDecisionAttributeValue.Text);
            int intIndex = 0;
            foreach (UniversalObjectBiz objBiz in objUniversalObjectColumnLst)
            {
                objColumn = new DataGridViewColumn();
                objColumn.Name = "Column"+ intIndex.ToString();
                objColumn.HeaderText = objBiz.DisplayName;
                objColumn.CellTemplate = objCell;
                grdMatrix.Columns.Add(objColumn);
                intIndex++;
            }
            intIndex = 0;
            string strTemp = "";
            List<string> lstAttributeStr = new List<string>();
            foreach (UniversalObjectBiz objBiz in UniversalObjectBiz.UniverseObjectLst)
            {
                grdMatrix.Rows.Add();
                objDr = grdMatrix.Rows[intIndex];
                objDr.HeaderCell.Value = objBiz.DisplayName;
                
                for (int intColumnIndex = 0; intColumnIndex < grdMatrix.Columns.Count; intColumnIndex++)
                {
                    strTemp = UniversalObjectBiz.GetDiscernibilityStr(objUniversalObjectColumnLst[intColumnIndex], objBiz);
                    objDr.Cells[intColumnIndex].Value = 
                       strTemp;
                    if (strTemp != "")
                        lstAttributeStr.Add(strTemp);

                }
                intIndex++;
            }
            lstAttributeStr = UniversalObjectBiz.GetReducts(lstAttributeStr);
            strTemp = "";
            string[] arrStr;
            foreach (string strInner in lstAttributeStr)
            {
                arrStr = strInner.Split(',');
                if (strTemp != "")
                    strTemp += "*";
                if (arrStr.Length > 1)
                {
                    strTemp += "(";
                    strTemp += strInner.Replace(',', '+');
                    strTemp += ")";
                }
                else
                    strTemp += strInner;

            }
            lblReducts.Text = strTemp;
        }
        #endregion
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (AttributeBiz.DecisionAttribute.ID == 0)
            {
                MessageBox.Show("Must Decide Decision attribute First");
                return;
            }
            FillDicrenibilityMatrix();

        }
    }
}