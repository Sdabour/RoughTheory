using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rough
{
    public partial class frmDSAttribute : Form
    {
        #region Private Data
        AttributeBiz _AttributeBiz;

        #endregion
        public frmDSAttribute()
        {
            InitializeComponent();
            FillAttributeLst();
        }
        #region Private Method
        void FillAttributeLst()
        {
            ListViewItem objItem;
            string[] arrStr;
            lstVAttribute.Items.Clear();
            AttributeBiz.AttributeLst = null;
            foreach (AttributeBiz objBiz in AttributeBiz.AttributeLst)
            {
                arrStr = new string[4];
                arrStr[0] = "";
                arrStr[1] = objBiz.Name;
                arrStr[2] = objBiz.ShortName;
                arrStr[3] = objBiz.IsDecision ? "Yes" : "";
                objItem = new ListViewItem(arrStr);
                lstVAttribute.Items.Add(objItem);
            }
        }
        void SetData()
        {
            txtName.Text = _AttributeBiz.Name;
            txtShortName.Text = _AttributeBiz.ShortName;
            chkIsDecision.Checked = _AttributeBiz.IsDecision;
            SetAttributeValue();
            
        }
        void SetAttributeValue()
        {
            grdAttributeValue.Rows.Clear();
            int intIndex = 0;
            DataGridViewRow objDr;
            foreach (AttributeValueBiz objBiz in _AttributeBiz.ValueLst)
            {
                grdAttributeValue.Rows.Add();
                objDr = grdAttributeValue.Rows[intIndex];
                objDr.Cells[0].Value = objBiz.Value;
                intIndex++;
            }
        }
        void GetData()
        {
            _AttributeBiz.Name = txtName.Text;
            _AttributeBiz.ShortName = txtShortName.Text;
            _AttributeBiz.IsDecision = chkIsDecision.Checked;
            GetAttributeValue();
        }
        void GetAttributeValue()
        {
            AttributeValueBiz objBiz;
            _AttributeBiz.ValueLst = new List<AttributeValueBiz>();
            foreach (DataGridViewRow objDr in grdAttributeValue.Rows)
            {

                if(objDr.Cells[0].Value != null && objDr.Cells[0].Value.ToString()!="")
                {
                    objBiz = new AttributeValueBiz();
                    objBiz.Value = objDr.Cells[0].Value.ToString();
                    objBiz.AttributeID = _AttributeBiz.ID;
                    _AttributeBiz.ValueLst.Add(objBiz);

                }
            }
        }
        void Clear()
        {
            _AttributeBiz = new AttributeBiz();
            txtName.Text = "";
            txtShortName.Text = "";
            chkIsDecision.Checked = false;
            grdAttributeValue.Rows.Clear();
        }
        bool CheckValidation()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Plz enter the name");
                return false;
            }

            return true;
        }
        #endregion
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstVAttribute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVAttribute.SelectedIndices.Count == 0)
                return;
            _AttributeBiz = AttributeBiz.AttributeLst[(int)lstVAttribute.SelectedIndices[0]];
            SetData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_AttributeBiz == null)
                _AttributeBiz = new AttributeBiz();
            if (!CheckValidation())
                return;
            GetData();
            if (_AttributeBiz.ID == 0)
                _AttributeBiz.Add();
            else
                _AttributeBiz.Edit();
            Clear();
            AttributeBiz.AttributeLst = null;
            FillAttributeLst();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_AttributeBiz == null || _AttributeBiz.ID == 0)
                return;
            _AttributeBiz.Delete();
            Clear();
            AttributeBiz.AttributeLst = null;
            FillAttributeLst();
        }
    }
}