using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

namespace VTool
{
    class ClsUpdateStorProcGenerator : ClsStorProcGenBase 
    {
        protected override void PrepareStoreProcedure()
        {
            procName = AppSetting.preUpdProc + "Update_" + dt.TableName + AppSetting.postUpdProc;  
            WriteStatementToOverwriteExistingProcedure();
            WriteGoStatement();
            WriteProcedureDeclaration();
            WriteParameterDefination();
            strBuilder.AppendLine("AS");
            WriteUpdateStatement();
            WriteSetValue();
            WriteWhereStatement();
            WriteGoStatement();
        }
        
        protected override void WriteStoreProcedureInFile()
        {
            string fileName = System.Configuration.ConfigurationSettings.AppSettings["OutPutFilePath"].ToString() +
                "\\UpdateProc\\" + procName + ".sql";
            File.WriteAllText(fileName, strBuilder.ToString());
        }
        
        private void WriteParameterDefination()
        {
            string tempStr = "";
            strBuilder.AppendLine("(");
            for (int i = 0; i <= dt.Rows.Count; i++)
            {
                if (tempStr != "")
                {
                    if (!IsThisLastField(i))
                        tempStr += ",";
                    strBuilder.AppendLine(tab1 + tempStr);
                }
                tempStr = "";
                if (i == dt.Rows.Count)
                    break;
                if (dt.Rows[i]["Column_Name"].ToString() == "AddedBy" ||
                    dt.Rows[i]["Column_Name"].ToString() == "AddedDt" ||
                    dt.Rows[i]["Column_Name"].ToString() == "ModifiedDt")
                    continue;
                tempStr = GetParamDefination(dt.Rows[i]["Column_Name"].ToString(),
                        dt.Rows[i]["Data_Type"].ToString(),
                        dt.Rows[i]["Character_Maximum_Length"].ToString(),
                        dt.Rows[i]["Numeric_Precision"].ToString(),
                        dt.Rows[i]["Numeric_Scale"].ToString());
            }
            strBuilder.AppendLine(")");
        }

        private void WriteUpdateStatement()
        {
            strBuilder.AppendLine(tab1 + "UPDATE " + dt.TableName + " SET");
        }

        private void WriteSetValue()
        {
            string tempStr = "";
            for (int i = 0; i <= dt.Rows.Count; i++)
            {
                if (tempStr != "")
                {
                    if (!IsThisLastField(i))
                        tempStr += ",";
                    strBuilder.AppendLine(tab2 + tempStr);
                }
                tempStr = "";
                if (i == dt.Rows.Count)
                    break;
                if (dt.Rows[i]["Column_Name"].ToString() == "AddedBy" ||
                    dt.Rows[i]["Column_Name"].ToString() == "AddedDt" ||
                    dt.Rows[i]["Column_Name"].ToString() == dt.TableName + "ID")
                    continue; 
                tempStr =GetSetValue(dt.Rows[i]["Column_Name"].ToString());
            }
        }

        private bool IsThisLastField(int i)
        {
            if (i == dt.Rows.Count )
                return true;
            for (; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Column_Name"].ToString() == "AddedBy" ||
                    dt.Rows[i]["Column_Name"].ToString() == "AddedDt")
                    continue;
                else
                    return false;
            }
            return true;
        }

        private void WriteWhereStatement()
        {
            strBuilder.AppendLine(tab1 + "WHERE " + dt.Rows[0]["Column_Name"].ToString() + " = @" +
                GetParamNameWRTAppSetting(dt.Rows[0]["Column_Name"].ToString()));  
        }

        private string GetSetValue(string dataType)
        {
            if (dataType == "ModifiedDt")
                return GetFieldOfTable(dataType) + " = GetDate()";
            else 
                return GetFieldOfTable(dataType) + " = " + GetValueForFieldOfTable(dataType);
        }
    }
}
