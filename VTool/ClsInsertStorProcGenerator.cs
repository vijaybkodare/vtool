using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
namespace VTool
{
    class ClsInsertStorProcGenerator : ClsStorProcGenBase  
    {
        protected override void  PrepareStoreProcedure()
        {
            procName = AppSetting.preInsProc  + "Insert_" + dt.TableName + AppSetting.postInsProc ;
            WriteStatementToOverwriteExistingProcedure(); 
            WriteGoStatement();
            WriteProcedureDeclaration(); 
            WriteParameterDefination();
            WriteProcedureBeginStatement(); 
            //WriteStatementForIDGeneration();
            WriteInsertStatement(); 
            WriteFieldOfTable();
            strBuilder.AppendLine(tab1 + "VALUES");
            WriteValueForFieldOfTable();
            //WriteStatementForRetrivingID();
            WriteProcedureEndingStatement();
            WriteGoStatement();
        }
        protected override void WriteStoreProcedureInFile()
        {
            string fileName = System.Configuration.ConfigurationSettings.AppSettings["OutPutFilePath"].ToString() +
                "\\InsertProc\\" + procName + ".sql";
            File.WriteAllText(fileName, strBuilder.ToString());
        }

        private void WriteParameterDefination()
        {
            string coma;
            strBuilder.AppendLine(tab1 + "(");
            for (int i = 1; i < dt.Rows.Count ; i++)
            {
                if (dt.Rows[i]["Column_Name"].ToString() == "ModifiedDt" ||
                    dt.Rows[i]["Column_Name"].ToString() == "ModifiedBy" ||
                    dt.Rows[i]["Column_Name"].ToString() == "AddedDt")
                    continue;
                if (i == dt.Rows.Count - 1)
                    coma = "";
                else
                    coma = ",";
                strBuilder.AppendLine(tab2 + GetParamDefination(dt.Rows[i]["Column_Name"].ToString(),
                    dt.Rows[i]["Data_Type"].ToString(),
                    dt.Rows[i]["Character_Maximum_Length"].ToString(),
                    dt.Rows[i]["Numeric_Precision"].ToString(),
                    dt.Rows[i]["Numeric_Scale"].ToString()) +  coma );
            }
            //strBuilder.AppendLine(tab2 + "@RecId VARCHAR(30) OUTPUT");
            strBuilder.AppendLine(tab1 + ")");
        }

        private void WriteStatementForIDGeneration()
        {
            strBuilder.AppendLine("/* To get ID */");
            strBuilder.AppendLine(tab2 + "SELECT @RecId = NextId FROM TableNextId WHERE IdName = '" + dt.Rows[0]["Column_Name"] + "'");
        }

        private void WriteStatementForRetrivingID()
        {
            strBuilder.AppendLine("/* To set next ID */");
            strBuilder.AppendLine(tab1 + "UPDATE TableNextId SET NextId = NextId + 1 WHERE IdName = '" + dt.Rows[0]["Column_Name"] + "'");
        }

        private void WriteProcedureEndingStatement()
        {
            //strBuilder.AppendLine(tab1 + "RETURN");
            strBuilder.AppendLine("END");
        }

        private void WriteProcedureBeginStatement()
        {
            strBuilder.AppendLine("AS");
            strBuilder.AppendLine("BEGIN");
        }

        private void WriteInsertStatement()
        {
            strBuilder.AppendLine(tab1 + "INSERT INTO " + dt.TableName );
        }

        private void WriteFieldOfTable()
        {
            string tempStr = "";
            strBuilder.AppendLine(tab1 + "(");
            for (int i = 0; i <= dt.Rows.Count; i++)
            {
                if (i == 0)
                    continue;//tempStr = "@RecId";
                if (tempStr != "")
                {
                    if( !IsThisLastField (i))
                        tempStr += ",";
                    strBuilder.AppendLine(tab2 + tempStr);
                }
                tempStr = "";
                if (i == dt.Rows.Count)
                    break;
                //if (dt.Rows[i]["Column_Name"].ToString() == "ModifiedDt" ||
                //    dt.Rows[i]["Column_Name"].ToString() == "ModifiedBy")
                //    continue;
                else
                    tempStr = GetFieldOfTable(dt.Rows[i]["Column_Name"].ToString());
            }
            strBuilder.AppendLine(tab1 + ")");
        }

        private bool IsThisLastField(int i)
        {
            if (i == dt.Rows.Count)
                return true;
            else
                return false;
            //for (; i < dt.Rows.Count; i++)
            //{
            //    if (dt.Rows[i]["Column_Name"].ToString() == "ModifiedDt" ||
            //        dt.Rows[i]["Column_Name"].ToString() == "ModifiedBy")
            //        continue;
            //    else
            //        return false;
            //}
            //return true;
        }

        private void WriteValueForFieldOfTable()
        {
            string tempStr="";
            strBuilder.AppendLine(tab1 + "(");
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
                //if (dt.Rows[i]["Column_Name"].ToString() == "ModifiedDt" ||
                //    dt.Rows[i]["Column_Name"].ToString() == "ModifiedBy")
                //    continue;

                if (i == 0)
                    continue;//tempStr = "@RecId";
                if (dt.Rows[i]["Column_Name"].ToString() == "ModifiedBy")
                    tempStr = GetValueForFieldOfTable("AddedBy");
                else
                {
                    if (dt.Rows[i]["Column_Name"].ToString() == "AddedDt" || dt.Rows[i]["Column_Name"].ToString() == "ModifiedDt")
                        tempStr = "GetDate()";
                    else
                        tempStr = GetValueForFieldOfTable(dt.Rows[i]["Column_Name"].ToString());
                }
            }
            strBuilder.AppendLine(tab1 + ")");
        }
    }
}
