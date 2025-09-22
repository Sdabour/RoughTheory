using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rough
{
    public partial class frmDSDiscerinibilityMatrixMultipleDecision : Form
    {
        public frmDSDiscerinibilityMatrixMultipleDecision()
        {
            InitializeComponent();
            //lblDecisionAttribute.Text = AttributeBiz.DecisionAttribute.ID != 0 ?
             //   AttributeBiz.DecisionAttribute.DisplayName : lblDecisionAttribute.Text;
            FillDecisonAttributeValueGrd();

        }
        #region Private Method
        void FillDecisonAttributeValueGrd()
        {
            List<AttributeBiz> lstDecisionAttribute = AttributeBiz.DecisionAttributeLst;
            if (lstDecisionAttribute.Count == 0)
                return;
          
            grdDecisionAtrribute.Rows.Clear();
            DataGridViewRow objDr;
            int intIndex = 0;
            foreach (AttributeBiz objBiz in lstDecisionAttribute)
            {
                grdDecisionAtrribute.Rows.Add();
                objDr = grdDecisionAtrribute.Rows[intIndex++];
                objDr.Cells[0].Value = objBiz.DisplayName;
                objDr.Cells[0].Tag = objBiz;
                ((DataGridViewComboBoxCell)objDr.Cells[1]).DataSource = objBiz.DisplayValueLst;
                objDr.Cells[1].Value = AttributeBiz.NonSpecifiedStr;

            }
           

           
        }
        void FillDicrenibilityMatrix()
        {
            grdMatrix.Columns.Clear();
            DataGridViewColumn objColumn = new DataGridViewColumn();
            DataGridViewCell objCell = new DataGridViewTextBoxCell();
            DataGridViewRow objDr;
            grdMatrix.Rows.Clear();

            List<UniversalObjectBiz> objUniversalObjectColumnLst = UniversalObjectBiz.GetUniversalObjectByDecision(GetDecisionLst());
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
            
            foreach (UniversalObjectBiz objBiz in UniversalObjectBiz.UniverseObjectLst)
            {
                grdMatrix.Rows.Add();
                objDr = grdMatrix.Rows[intIndex];
                objDr.HeaderCell.Value = objBiz.DisplayName;
                
                for (int intColumnIndex = 0; intColumnIndex < grdMatrix.Columns.Count; intColumnIndex++)
                {
                    objDr.Cells[intColumnIndex].Value = 
                        UniversalObjectBiz.GetDiscernibilityStr(objUniversalObjectColumnLst[intColumnIndex],objBiz);

                }
                intIndex++;
            }
        }
        List<AttributeValueBiz> GetDecisionLst()
        {
            List<AttributeValueBiz> Returned = new List<AttributeValueBiz>();
            AttributeValueBiz objValueBiz;
            foreach (DataGridViewRow objDr in grdDecisionAtrribute.Rows)
            {
                if (objDr.Cells[0].Tag == null)
                    continue;
                objValueBiz = new AttributeValueBiz();
                objValueBiz.AttributeID = ((AttributeBiz)objDr.Cells[0].Tag).ID;
                if (objDr.Cells[1].Value != null && objDr.Cells[1].Value.ToString() != "")
                    objValueBiz.Value = objDr.Cells[1].Value.ToString();
                else
                    objValueBiz.Value = AttributeBiz.NonSpecifiedStr;
                    Returned.Add(objValueBiz);
            }
            return Returned;
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