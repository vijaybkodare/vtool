using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

namespace VTool
{
    public class ClsENTClassCodeGenerator
    {
        protected DataTable dt;
        protected StringBuilder strBuilder;
        protected string tab1 = "\t";
        protected string tab2 = "\t\t";
        protected string tab3 = "\t\t\t";
        protected string tab4 = "\t\t\t\t";

        public void GenerateClassCode(string tableName)
        {
            strBuilder = new StringBuilder();
            dt = DBHandler.GetTableWithSchema(tableName);
            PrepareClassCode();
            WriteClassCodeInFile();
        }
        private void PrepareClassCode()
        {
            WriteImportsStatement();
            strBuilder.AppendLine("namespace " + AppSetting.namespaceName + ".Model");
            strBuilder.AppendLine("{");
            WriteClassCode();
            strBuilder.AppendLine("}");
        }
        protected void WriteClassCodeInFile()
        {
            string fileName = System.Configuration.ConfigurationSettings.AppSettings["OutPutFilePath"].ToString() +
                "\\ClassCode\\" + GetClassName() + ".cs";
            File.WriteAllText(fileName, strBuilder.ToString());
        }
        private void WriteImportsStatement()
        {
            strBuilder.AppendLine("//Code is auto generated by VTool");
            strBuilder.AppendLine("using System.Data;");
        }
        private void WriteClassCode()
        {
            strBuilder.AppendLine(tab1 + "public class " + GetClassName() + ": ENTBase");
            strBuilder.AppendLine(tab1 + "{");
            WriteVariableDeclaration();
            WritePropertiesOfVariable();
            WriteRegion("Constructor");
            WriteConstructor(); 
            WriteInitFunction();
            WriteCopyFunction();
            WriteEndRegion();
            strBuilder.AppendLine(tab1 + "}");
        }
        private void WriteVariableDeclaration()
        {
            WriteRegion("private Variables");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strBuilder.AppendLine(GetVariableDeclaration(dt.Rows[i]["Column_Name"].ToString(),
                    dt.Rows[i]["Data_Type"].ToString()));
            }
            WriteEndRegion();
        }
        private void WriteConstructor()
        {
            WriteFunctionDefination("public", AppSetting.preClass + "ENT" + dt.TableName + AppSetting.postClass + "()", "");
            strBuilder.AppendLine(tab3 + "Init();");
            WriteEndFunction();
        }
        private void WriteInitFunction()
        {
            WriteFunctionDefination("private", "Init()", "void");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strBuilder.AppendLine(tab3 + GetInitDefForVar(dt.Rows[i]["Column_Name"].ToString(),
                    dt.Rows[i]["Data_Type"].ToString()));
            }
            WriteEndFunction();
        }
        private void WriteCopyFunction()
        {
            WriteFunctionDefination("private", "Copy(" + GetClassName() + " myEntity)", "void");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strBuilder.AppendLine(tab3 + dt.Rows[i]["Column_Name"].ToString() + " = myEntity." + dt.Rows[i]["Column_Name"].ToString() + ";");
            }
            WriteEndFunction();
        }
        private void WriteFunctionDefination(string accessModifier, string funcName, string retType)
        {
            strBuilder.AppendLine(tab2 + accessModifier + " " + retType + " " + funcName);
            strBuilder.AppendLine(tab2 + "{");
        }
        private void WriteEndRegion()
        {
            strBuilder.AppendLine("#endregion");
        }
        private void WriteBlankLine()
        {
            strBuilder.AppendLine("");
        }
        private void WriteRegion(string regionDesc)
        {
            WriteBlankLine();
            strBuilder.AppendLine("#region " + regionDesc);
        }
        private string GetVariableDeclaration(string colName, string dataType)
        {
            string str = tab2 + "private " + GetDataType(dataType) + " " + GetVarNameWRTSetting(colName) + ";";
            return str;
        }
        private string GetDataType(string dataType)
        {

            string str = "";
            switch (dataType)
            {
                case "nvarchar": str = "string"; break;
                case "varchar": str = "string"; break;
                case "numeric": str = "decimal"; break;
                case "datetime": str = "System.DateTime"; break;
                case "bit": str = "decimal"; break;
                default: str = "decimal"; break;
            }
            return str;
        }
        private string GetParamDataType(string dataType)
        {

            string str = "";
            switch (dataType)
            {
                case "nvarchar": str = "String"; break;
                case "varchar": str = "String"; break;
                case "numeric": str = "Decimal"; break;
                case "datetime": str = "DateTime"; break;
                case "bit": str = "Decimal"; break;
                default: str = "Decimal"; break;
            }
            return str;
        }
        private string GetSqlDataType(string dataType)
        {
            string str = "";
            switch (dataType)
            {
                case "nvarchar": str = "VarChar"; break;
                case "varchar": str = "VarChar"; break;
                case "numeric": str = "Decimal"; break;
                case "datetime": str = "DateTime"; break;
                case "bit": str = "Bit"; break;
                default: str = "Decimal"; break;
            }
            return str;
        }
        private string GetVarNameWRTSetting(string var)
        {
            return AppSetting.preVar + var + AppSetting.postVar;
        }
        private void WritePropertiesOfVariable()
        {
            WriteRegion("Properties (Class Attributes)");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strBuilder.AppendLine(GetPropertyForVariable(dt.Rows[i]["Column_Name"].ToString(),
                    dt.Rows[i]["Data_Type"].ToString()));
            }
            WriteEndRegion();
        }
        private string GetClassName()
        {
            return AppSetting.preClass + "ENT" + dt.TableName + AppSetting.postClass;
        }
        private string GetCopyDefination(string dataType)
        {
            string str = GetVarNameWRTSetting(dataType);
            return str + " = " + "this." + str;
        }
        private string GetInitDefForVar(string colName, string dataType)
        {
            string str = "";
            switch (dataType)
            {
                case "nvarchar": str = "\"\""; break;
                case "varchar": str = "\"\""; break;
                case "numeric": str = "0"; break;
                case "bit": str = "0"; break;
                case "datetime": str = "System.DateTime.Now"; break;
                default: str = "0"; break;
            }
            return colName + " = " + str + ";";
        }
        private string GetCopyDefForVar(string colName, string dataType)
        {
            string str = "";
            switch (dataType)
            {
                case "nvarchar": str = "\"\""; break;
                case "varchar": str = "\"\""; break;
                case "numeric": str = "0"; break;
                case "bit": str = "0"; break;
                case "datetime": str = "System.DateTime.Now"; break;
                default: str = "0"; break;
            }
            return colName + " = myEntity." + colName + ";";
        }
        private string GetPropertyForVariable(string colName, string dataType)
        {
            StringBuilder L_strBuilder = new StringBuilder();
            L_strBuilder.AppendLine(tab2 + "public " + GetDataType(dataType) + " " + colName );
            L_strBuilder.AppendLine(tab2 + "{");
            L_strBuilder.AppendLine(tab2 + "get{return " + GetVarNameWRTSetting(colName) + ";}");
            L_strBuilder.AppendLine(tab3 + "set{" + GetVarNameWRTSetting(colName) + " = value; OnPropertyChanged(\"" + colName + "\");}");
            L_strBuilder.AppendLine(tab2 + "}");
            return L_strBuilder.ToString();
        }
        private string GetSetValueDefination(string colName, string dataType)
        {
            string str = "_" + dt.TableName + "." + GetVarNameWRTSetting(colName) + " = " +
                "System.Convert.";
            switch (dataType)
            {
                case "nvarchar": str += "ToString"; break;
                case "varchar": str += "ToString"; break;
                case "numeric": str += "ToDecimal"; break;
                case "bit": str += "ToDecimal"; break;
                case "datetime": str += "ToDateTime"; break;
                default: str += "ToDecimal"; break;
            }
            str += "(dr[\"" + colName + "\"]);";
            return str;
        }
        private void WriteEndFunction()
        {
            strBuilder.AppendLine("}");
        }
    }
}

