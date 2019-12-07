using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Commons;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

public class OLanguages
{
    public OLanguages()
    {
    }

    public void AddLanguage(ILanguages objLanguage)
    {
        SqlHelper.ExecuteNonQuery(IConnections.CNStr, "AddLaguage", objLanguage.MS_MODULE, objLanguage.FORM, objLanguage.KEYWORD, objLanguage.VIETNAM, objLanguage.ENGLISH);
    }

    public void UpdateLanguage(ILanguages objLanguage)
    {
        SqlHelper.ExecuteNonQuery(IConnections.CNStr, "UpdateLaguage", objLanguage.STT, objLanguage.MS_MODULE, objLanguage.FORM, objLanguage.KEYWORD, objLanguage.VIETNAM, objLanguage.ENGLISH);
    }

    public void DeleteLanguage(int ID)
    {
        SqlHelper.ExecuteNonQuery(IConnections.CNStr, "DeleteLaguage");
    }

    public string GetLanguage(string FormName, string Keyword)
    {
        string sStr;
        try
        {
            sStr = Convert.ToString(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spGetNN", Modules.ModuleName, FormName, Keyword, Modules.TypeLanguage));
        }
        catch
        {
            sStr = "?" + Keyword + "?";
        }
        return sStr;
    }


    public string GetLanguage(string ModuleName, string FormName, string Keyword, int TypeLanguage)
    {
        string sStr;
        try
        {
            sStr = Convert.ToString(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spGetNN", ModuleName, FormName, Keyword, TypeLanguage));
        }
        catch 
        {
            sStr = "?" + Keyword + "?";
        }
        return sStr;
    }
    public DataTable GetLanguages()
    {
        DataTable dtTable = new DataTable();
        dtTable.Load(SqlHelper.ExecuteReader(IConnections.CNStr, "GetLanguages"));
        return dtTable;
    }
}
