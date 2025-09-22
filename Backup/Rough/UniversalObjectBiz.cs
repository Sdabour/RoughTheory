using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace Rough
{
    public class UniversalObjectBiz
    {
        #region Private Data
        int _ID;
        string _Name;
        string _ShortName;
        List<UniversalObjectValueBiz> _ValueLst;
        List<UniversalObjectBiz> _DiscernibilityLst;
        static List<UniversalObjectBiz> _UniverseObjectLst;
        #endregion
        #region Constructor
        public UniversalObjectBiz()
        {
 
        }
        public UniversalObjectBiz(DataRow objDr)
        {
            SetData(objDr);
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
        public List<UniversalObjectValueBiz> ValueLst
        {
            set
            {
                _ValueLst = value;
            }
            get
            {
                if (_ValueLst == null)
                {
                    _ValueLst = new List<UniversalObjectValueBiz>();
                }
                return _ValueLst;
            }
        }
        public List<UniversalObjectBiz> DiscernibilityLst
        {
            set
            {
                _DiscernibilityLst = value;
            }
            get
            {
                if (_DiscernibilityLst == null)
                {
                    _DiscernibilityLst = new List<UniversalObjectBiz>();
                    if(AttributeBiz.DecisionAttribute.ID == 0)
                        return _DiscernibilityLst;
                    foreach (UniversalObjectBiz objBiz in UniverseObjectLst)
                    {
                        if (GetDecisionValue().Value != objBiz.GetDecisionValue().Value && objBiz.ID > ID)
                            _DiscernibilityLst.Add(objBiz);
                    }

                }
                return _DiscernibilityLst;
            }
        }
        public static List<UniversalObjectBiz> UniverseObjectLst
        {
            set
            {
                _UniverseObjectLst = value;
            }
            get
            {
                if (_UniverseObjectLst == null)
                {
                    _UniverseObjectLst = new List<UniversalObjectBiz>();
                    DataTable dtObject = Search();
                    DataTable dtObjectValue = GetObjectValues();
                   UniversalObjectBiz objTemp;
                    DataRow[] arrDr;
                    UniversalObjectValueBiz objValueBiz;
                    foreach (DataRow objDr in dtObject.Rows)
                    {
                        objTemp = new UniversalObjectBiz(objDr);
                        objTemp.ValueLst = new List<UniversalObjectValueBiz>();
                        foreach (AttributeBiz objAttributeBiz in AttributeBiz.AttributeLst)
                        {

                            arrDr = dtObjectValue.Select("ObjectID=" + objTemp.ID + 
                                " and ObjectAttributeID=" + objAttributeBiz.ID );
                            objValueBiz = new UniversalObjectValueBiz();
                            if (arrDr.Length > 0)
                            {
                                objValueBiz = new UniversalObjectValueBiz(arrDr[0]);
                                objValueBiz.AttributeBiz = objAttributeBiz;
                            }
                            else
                            {
                                objValueBiz.AttributeBiz = objAttributeBiz;
                                objValueBiz.AttributeID = objAttributeBiz.ID;
                                objValueBiz.Value = AttributeBiz.NonSpecifiedStr;
                            }
                            objTemp.ValueLst.Add(objValueBiz);
                            //_AttibuteLst.Add(objTemp);
                        }
                        _UniverseObjectLst.Add(objTemp);

                    }

                }
                return _UniverseObjectLst;
            }
        }
        UniversalObjectValueBiz GetDecisionValue()
        {
            AttributeBiz objDecision = AttributeBiz.DecisionAttribute;
            foreach (UniversalObjectValueBiz objBiz in ValueLst)
            {
                if (objBiz.AttributeID != 0 && objBiz.AttributeID == objDecision.ID)
                    return objBiz;
            }
            return new UniversalObjectValueBiz();
        }

        #endregion
        #region  Private Methods
        void SetData(DataRow objDr)
        {
            _ID = int.Parse(objDr["ObjectID"].ToString());
            _Name = objDr["ObjectName"].ToString();
            _ShortName = objDr["ObjectShortName"].ToString();
        }

        static DataTable Search()
        {
            string strSql = "SELECT  ObjectID, ObjectName, ObjectShortName "+
                  " FROM         dbo.DSUniversalObject "; 
            return BaseDb.RoughBaseDb.ReturnDatatable(strSql);
        }
        static DataTable GetObjectValues()
        {
            string strSql = "SELECT     ObjectID, ObjectAttributeID, ObjectAttributeValue "+
                   " FROM         dbo.DSUniversalObjectAttribueValue ";
            return BaseDb.RoughBaseDb.ReturnDatatable(strSql);
        }
        static bool Contains(string str1, string str2,out string strReduct)
        {
            string strMaster = "";
            string strSlave = "";
            strReduct = "";
            if (str1.Length == str2.Length)
            {
                strMaster = str1;
                strSlave = str2;

            }
            else
            {
                strMaster = str1.Length > str2.Length ? str1 : str2;
                strSlave = str1.Length < str2.Length ? str1 : str2;
            }
            bool Returned = true;
            bool blIsFound = false;
            string[] arrMastr = strMaster.Split(',');
            string[] arrSlave = strSlave.Split(',');
            foreach (string strS in arrSlave)
            {
                blIsFound = false;
                foreach (string strM in arrMastr)
                {
                    if (strS == strM)
                    {
                        blIsFound = true;
                        break;
                    }
                }
                if (!blIsFound)
                    Returned = false;
            }
            strReduct = strSlave;
            return Returned;
        }
        #endregion
        #region Public Method
        public static void JoinDecisionTable()
        {
            string[] arrStr = new string[UniverseObjectLst.Count + 1];
            arrStr[0] = "delete  FROM dbo.DSUniversalObject "+
                  " delete from dbo.DSUniversalObjectAttribueValue ";
            int intIndex = 0;
            string strTemp = "";
            foreach (UniversalObjectBiz objBiz in UniverseObjectLst)
            {
                intIndex++;
                strTemp = "insert into  DSUniversalObject (ObjectID, ObjectName, ObjectShortName) "+
                    " values ("+ intIndex + ",'" + objBiz.Name  + "','" +  objBiz.ShortName  +"' ) ";
                foreach (UniversalObjectValueBiz objValueBiz in objBiz.ValueLst)
                {
                    strTemp += "  insert into DSUniversalObjectAttribueValue "+
                        " (ObjectID, ObjectAttributeID, ObjectAttributeValue)  values "+
                        " ("+ intIndex + ","  + objValueBiz.AttributeID + ",'" + objValueBiz.Value +"') ";
                }
                arrStr[intIndex] = strTemp;
            }
            BaseDb.RoughBaseDb.ExecuteNonQuery(arrStr);
            _UniverseObjectLst = null;
            AttributeBiz.AttributeLst = null;
        }
        public static List<UniversalObjectBiz> GetUniversalObjectByDecision(string strValue)
        {
            List<UniversalObjectBiz> Returned = new List<UniversalObjectBiz>();
            AttributeBiz objDecision = AttributeBiz.DecisionAttribute;
            foreach (UniversalObjectBiz objBiz in UniverseObjectLst)
            {
                if (strValue == AttributeBiz.NonSpecifiedStr || objBiz.GetDecisionValue().Value == strValue)
                    Returned.Add(objBiz);
            }
            return Returned;
        }
        public static List<UniversalObjectBiz> GetUniversalObjectByDecision(List<AttributeValueBiz> lstValue)
        {
            List<UniversalObjectBiz> Returned = new List<UniversalObjectBiz>();
            AttributeBiz objDecision = AttributeBiz.DecisionAttribute;
            bool blIsDecided;
            foreach (UniversalObjectBiz objBiz in UniverseObjectLst)
            {
                blIsDecided = true;
                //if (lstValue == AttributeBiz.NonSpecifiedStr || objBiz.GetDecisionValue().Value == lstValue)
                    Returned.Add(objBiz);
            }
            return Returned;
        }

        public static string GetDiscernibilityStr(UniversalObjectBiz objBiz1, UniversalObjectBiz objBiz2)
        {
            string REturned = "";
            if (objBiz1.ID > objBiz2.ID || objBiz1.GetDecisionValue().Value == objBiz2.GetDecisionValue().Value)
                return "";
            for (int intIndex = 0; intIndex < objBiz1.ValueLst.Count; intIndex++)
            {
                if (!objBiz1.ValueLst[intIndex].AttributeBiz.IsDecision && objBiz1.ValueLst[intIndex].Value != objBiz2.ValueLst[intIndex].Value)
                {
                    if (REturned != "")
                        REturned += ",";
                    REturned += objBiz1.ValueLst[intIndex].AttributeBiz.DisplayName;
                }
            }

            return REturned;
        }
        public static string GetDiscernibilityStrForMultipleDecisionAttributes(UniversalObjectBiz objBiz1, UniversalObjectBiz objBiz2)
        {
            string REturned = "";
            if (objBiz1.ID > objBiz2.ID || objBiz1.GetDecisionValue().Value == objBiz2.GetDecisionValue().Value)
                return "";
            for (int intIndex = 0; intIndex < objBiz1.ValueLst.Count; intIndex++)
            {
                if (!objBiz1.ValueLst[intIndex].AttributeBiz.IsDecision && objBiz1.ValueLst[intIndex].Value != objBiz2.ValueLst[intIndex].Value)
                {
                    if (REturned != "")
                        REturned += ",";
                    REturned += objBiz1.ValueLst[intIndex].AttributeBiz.DisplayName;
                }
            }

            return REturned;
        }
        public static List<string> GetReducts(List<string> lstAttributeStr)
        {
            List<string> Returned = new List<string>();
         
            bool blIsFound = false;
            int intIndex = 0;
            string strReduct = "";
            foreach (string strTemp in lstAttributeStr)
            {
                blIsFound = false;
                intIndex = 0;
                foreach (string strInner in Returned)
                {

                    if (Contains(strInner, strTemp, out strReduct))
                    {
                        Returned[intIndex] = strReduct;
                        blIsFound = true;
                        break;
                    }
                
                        intIndex++;
                }
                if (!blIsFound)
                    Returned.Add(strTemp);
 
            }
            return Returned;    
 
        }
        #endregion
    }
}
