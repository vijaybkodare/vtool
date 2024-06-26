using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace VTool
{
    class ClsStorProcGenBase
    {
        protected DataTable dt;
        protected StringBuilder strBuilder;
        protected string procName;
        protected string tab1 = "\t";
        protected string tab2 = "\t\t";
        public void GenerateStoreProcedure(string tableName)
        {
            strBuilder = new StringBuilder();
            dt = DBHandler.GetTableWithSchema(tableName);
            PrepareStoreProcedure();
            WriteStoreProcedureInFile();
        }
        protected string GetParamNameWRTAppSetting(string param)
        {
            return AppSetting.preParam + param + AppSetting.postParam;
        }
        protected string GetParamDefination(string colName, string dataType, string charMaxLength, string numPrecesion, string numScale)
        {
            string str = "@" + GetParamNameWRTAppSetting(colName) + " ";
            switch (dataType)
            {
                case "numeric":
                    str += "[NUMERIC] ";
                    str += "(" + numPrecesion + "," + numScale + ")";
                    break;
                case "varchar":
                    str += "[VARCHAR] ";
                    str += "(" + charMaxLength + ")";
                    break;
                case "nvarchar":
                    str += "[NVARCHAR] ";
                    str += "(" + charMaxLength + ")";
                    break;
                case "datetime": str += "[DATETIME]"; break;
                case "bit": str += "[BIT]"; break;
                case "tinyint": str += "[TINYINT]"; break;
                case "smallint": str += "[SMALLINT]"; break;
                case "int": str += "[INT]"; break;
                case "smallmoney": str += "[SMALLMONEY]"; break;
                case "money": str += "[MONEY]"; break;
            }
            return str;
        }
        protected string GetFieldOfTable(string dataType)
        {
            return "[" + dataType + "]";
        }
        protected string GetValueForFieldOfTable(string dataType)
        {
            return "@" + GetParamNameWRTAppSetting(dataType);
        }
        protected void WriteGoStatement()
        {
            strBuilder.AppendLine("");
            strBuilder.AppendLine("GO");
            strBuilder.AppendLine("");
        }
        protected void WriteProcedureDeclaration()
        {
            strBuilder.AppendLine("CREATE PROCEDURE [" + procName + "]");
        }
        protected void WriteStatementToOverwriteExistingProcedure()
        {
            strBuilder.AppendLine("/* Procedure is auto generated by VTool */");
            strBuilder.AppendLine("");
            strBuilder.AppendLine("/* To overite existing procedure */");
            strBuilder.AppendLine("IF EXISTS(SELECT * FROM dbo.sysobjects WHERE id = ");
            strBuilder.AppendLine(tab1 + "object_id(N'[dbo].[" + procName + "]')");
            strBuilder.AppendLine(tab1 + "AND OBJECTPROPERTY(id, N'IsProcedure') = 1)");
            strBuilder.AppendLine("DROP PROCEDURE [dbo].[" +
                procName + "]");
        }
        protected virtual void PrepareStoreProcedure() { }
        protected virtual void WriteStoreProcedureInFile() { }
    }
}
