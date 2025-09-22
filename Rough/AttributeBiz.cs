using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace Rough
{
    public class AttributeBiz
    {
        #region Private Data
        int _ID;
        string _Name;
        string _ShortName;
        bool _IsDecision;
        public static string NonSpecifiedStr = "Not Specified";
        List<AttributeValueBiz> _ValueLst;
        static List<AttributeBiz> _AttibuteLst;
        #endregion
        #region Constructor
        public AttributeBiz(DataRow objDr)
        {
            SetData(objDr);
        }
        public AttributeBiz()
        { 
        }

        #endregion
        #region Public Properties
        public int ID
        {
            set
            {
                _ID = value;
            }
            get
            {
                return _ID;
            }
        }
        public string Name
        {
            set
            {
                _Name = value;
            }
            get
            {
                return _Name;
            }
        }
        public string ShortName
        {
            set
            {
                _ShortName = value;
            }
            get
            {
                return _ShortName;
            }

        }
        public string DisplayName
        {
            get
            {
                return _ShortName == null || _ShortName == "" ? _Name : _ShortName;
            }
        }

        public bool IsDecision
        {
            set
            {
                _IsDecision = value;
            }
            get
            {
                return _IsDecision;
            }
        }
        public List<AttributeValueBiz> ValueLst
        {
            set
            {
                _ValueLst = value;
            }
            get
            {
                if (_ValueLst == null)
                {
                    _ValueLst = new List<AttributeValueBiz>();

                }
                return _ValueLst;
            }
        }
        public List<AttributeValueBiz> DisplayValueLst
        {
          
            get
            {
                List<AttributeValueBiz> Returned = new List<AttributeValueBiz>();
                AttributeValueBiz objTemp = new AttributeValueBiz();
                objTemp.Value = AttributeBiz.NonSpecifiedStr;
                Returned.Add(objTemp);
               foreach(AttributeValueBiz objBiz in ValueLst)
                {

                    Returned.Add(objBiz);
                }
                return Returned;
            }
        }
        public static List<AttributeBiz> AttributeLst
        {
            set
            {
                _AttibuteLst = value;
            }
            get
            {
                if (_AttibuteLst == null)
                {
                    _AttibuteLst = new List<AttributeBiz>();
                    DataTable dtAttribute = Search();
                    DataTable dtAttributeValue = GetAttributeValues();
                    AttributeBiz objTemp;
                    DataRow[] arrDr;
                    foreach (DataRow objDr in dtAttribute.Rows)
                    {
                        objTemp = new AttributeBiz(objDr);
                        objTemp.ValueLst = new List<AttributeValueBiz>();
                        arrDr = dtAttributeValue.Select("AttributeID="+ objTemp.ID);
                        foreach (DataRow objValueDr in arrDr)
                        {
                            objTemp.ValueLst.Add(new AttributeValueBiz(objValueDr));
                        }
                        _AttibuteLst.Add(objTemp);
                    }
                }
                return _AttibuteLst;
            }
        }
        public static AttributeBiz DecisionAttribute
        {
            get
            {
                foreach (AttributeBiz objBiz in AttributeLst)
                {
                    if (objBiz.IsDecision)
                        return objBiz;
                }
                return new AttributeBiz();
            }
        }
        public static List<AttributeBiz> DecisionAttributeLst
        {
            get
            {
                List<AttributeBiz> Returned = new List<AttributeBiz>();
                foreach (AttributeBiz objBiz in AttributeLst)
                {
                    if (objBiz.IsDecision)
                        Returned.Add(objBiz);
                }
                return Returned;
            }
        }
        #endregion
        #region  Private Methods
        void SetData(DataRow objDr)
        {
            _ID = int.Parse(objDr["AttributeID"].ToString());
            _Name = objDr["AttributeName"].ToString();
            _ShortName = objDr["AttributeShortName"].ToString();
            _IsDecision = bool.Parse(objDr["AttributeIsDicision"].ToString());
        }
        void JoinAttributeValue()
        {
            string[] arrStr = new string[ValueLst.Count + 1];
            int intIndex = 0;
            arrStr[intIndex] = "delete from DSAttributeValue where AttributeID=" + _ID;
            foreach (AttributeValueBiz objBiz in ValueLst)
            {
                intIndex++;
                arrStr[intIndex] = "insert into DSAttributeValue ( AttributeID, AttributeValue)" +

                    " values (" + _ID + ",'" + objBiz.Value + "') ";
            }
            BaseDb.RoughBaseDb.ExecuteNonQuery(arrStr);
        }
        static DataTable Search()
        {
            string strSql = "SELECT  AttributeID, AttributeName, AttributeShortName, AttributeIsDicision "+
                   " FROM   dbo.DSAttribute ";
            return BaseDb.RoughBaseDb.ReturnDatatable(strSql);
        }
        static DataTable GetAttributeValues()
        {
            string strSql = "SELECT     AttributeID, AttributeValue "+
                   " FROM  dbo.DSAttributeValue ";
            return BaseDb.RoughBaseDb.ReturnDatatable(strSql);
        }
        #endregion
        #region Public Method
        public void Add()
        {
            int intIsDecision = _IsDecision ? 1 : 0;
            string strSql = "insert into DSAttribute (AttributeName, AttributeShortName, AttributeIsDicision)"+
                " values ('"+_Name+"','"+ _ShortName +"',"+ intIsDecision +")";
            _ID = BaseDb.RoughBaseDb.InsertIdentityTable(strSql);
            if (_IsDecision)
            {
                strSql = "update DSAttribute set AttributeIsDicision = 0 where AttributeID<>"+_ID;
                BaseDb.RoughBaseDb.ExecuteNonQuery(strSql);
            }
            JoinAttributeValue();
            _AttibuteLst = null;
            UniversalObjectBiz.UniverseObjectLst = null;

        }
        public void Edit()
        {
            int intIsDecision = _IsDecision ? 1 : 0;
            string strSql = "update DSAttribute set AttributeName='"+ _Name +"'"+
                ", AttributeShortName='"+ _ShortName +"'"+
                ", AttributeIsDicision=" +intIsDecision +
                " where AttributeID="+ _ID;
            BaseDb.RoughBaseDb.ExecuteNonQuery(strSql);
            if (_IsDecision)
            {
                strSql = "update DSAttribute set AttributeIsDicision = 0 where AttributeID<>" + _ID;
                BaseDb.RoughBaseDb.ExecuteNonQuery(strSql);
            }
            JoinAttributeValue();
            _AttibuteLst = null;
            UniversalObjectBiz.UniverseObjectLst = null;

        }
        public void Delete()
        {
            string strSql = "delete from DSAttribute  where AttributeID=" + _ID;
            strSql += " delete from DSAttributeValue where AttributeID ="+_ID;
            BaseDb.RoughBaseDb.ExecuteNonQuery(strSql);
        }
        #endregion

    }
}
