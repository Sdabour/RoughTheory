using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace Rough
{
    public class AttributeValueBiz
    {
        #region Private Data
        int _AttributeID;
        string _Value;
        #endregion
        #region Constructor
        public AttributeValueBiz()
        { 
        }
        public AttributeValueBiz(DataRow objDr)
        {
            SetData(objDr);
        }
        #endregion
        #region Public Properties
        public int AttributeID
        {
            set
            {
                _AttributeID = value;
            }
            get
            {
                return _AttributeID;
            }
        }
        public string Value
        {
            set
            {
                _Value = value;
            }
            get
            {
                return _Value;
            }

        }
        #endregion
        #region  Private Methods
        void SetData(DataRow objDr)
        {
            _AttributeID = int.Parse(objDr["AttributeID"].ToString());
            _Value = objDr["AttributeValue"].ToString();
 
        }
        #endregion
        #region Public Method
        #endregion
    }
}
