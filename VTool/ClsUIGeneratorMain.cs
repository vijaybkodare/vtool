using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

namespace VTool
{
    class ClsUIGeneratorMain: ClsCodeGenBase 
    {
        #region Variables
        #endregion
        public void GenerateCode(string tableName)
        {
            InitCodeGenerator(tableName);
            WriteImportsStatement();
            WriteNamespace();
            WriteClassDefinition(AppSetting.preUIName + dt.TableName + AppSetting.postUIName, "Form");
            WriteConstructor();
            WriteClosingBrace();
            WriteClosingBrace();
            WriteCodeInFile("\\UICode\\", AppSetting.preUIName, AppSetting.postUIName, ".cs");
        }
        private void WriteConstructor()
        {
            WriteConstrFunction("public", AppSetting.preUIName + dt.TableName + AppSetting.postUIName);
            strBuilder.AppendLine("InitializeComponent();");
            WriteClosingBrace();
        }
        private void GenerateUIFileDesigner()
        {
            WriteNamespace();
            WriteClassDefinition(AppSetting.preUIName + dt.TableName + AppSetting.postUIName, ""); 
        }
        private void WriteCommonStatement()
        {
            strBuilder.AppendLine("private System.ComponentModel.IContainer components = null;");
            strBuilder.AppendLine("protected override void Dispose(bool disposing)");
            strBuilder.AppendLine("{");
            strBuilder.AppendLine("if (disposing && (components != null))");
            strBuilder.AppendLine("{");
            strBuilder.AppendLine("components.Dispose();");
            strBuilder.AppendLine("}");
            strBuilder.AppendLine("base.Dispose(disposing);");
            strBuilder.AppendLine("}");
        }
    }
}
