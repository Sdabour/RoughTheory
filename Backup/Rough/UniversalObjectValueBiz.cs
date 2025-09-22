using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace Rough
{
    public class UniversalObjectValueBiz
    {
        #region Private Data
        int _ObjectID;
        int _AttributeID;
        string _Value;
        AttributeBiz _AttributeBiz;
        #endregion
        #region Constructor
        public UniversalObjectValueBiz()
        { }
        public UniversalObjectValueBiz(DataRow objDr)
        {
            SetData(objDr);
        }
        #endregion
        #region Public Properties
        public int ObjectID
        {
            set
            {
                _ObjectID = value;
            }
            get
            {
                return _ObjectID;
            }
           
        }
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
        public AttributeBiz AttributeBiz
        {
            set
            {
                _AttributeBiz = value;
            }
            get
            {
                return _AttributeBiz;
            }

        }
        #endregion
        #region  Private Methods
        void SetData(DataRow objDr)
        {
            _ObjectID = int.Parse(objDr["ObjectID"].ToString());
            _AttributeID = int.Parse(objDr["ObjectAttributeID"].ToString());
            _Value = objDr["ObjectAttributeValue"].ToString();
        }
        #endregion
        #region Public Method
        
        #endregion
    }
}
