using System;
using System.Collections.Generic;
using System.Text;

namespace VTool
{
    class ClsUIGeneratorDesig : ClsCodeGenBase 
    {
        #region Variables
        #endregion
        public void GenerateCode(string tableName)
        {
            InitCodeGenerator(tableName);
            WriteMyComment(); 
            //WriteImportsStatement();
            WriteNamespace();
            WriteClassDefinition(AppSetting.preUIName + dt.TableName + AppSetting.postUIName, "");
            strBuilder.AppendLine("private System.ComponentModel.IContainer components = null;");
            WriteDisposeFun();
            WriteRegion("Windows Form Designer generated code");
            WriteInitializeComponentFun();
            WriteControlDeclaration();
            WriteEndRegion(); 
            WriteClosingBrace();
            WriteClosingBrace();
            WriteCodeInFile("\\UICode\\", AppSetting.preUIName, AppSetting.postUIName + ".Designer", ".cs");
        }
        private void WriteConstructor()
        {
            WriteFunctionDefination("public", AppSetting.preUIName + dt.TableName + AppSetting.postUIName, "");
            strBuilder.AppendLine("InitializeComponent();");
            WriteClosingBrace();
        }
        private void GenerateUIFileDesigner()
        {
            WriteNamespace();
            WriteClassDefinition(AppSetting.preUIName + dt.TableName + AppSetting.postUIName, "");
        }
        private void WriteDisposeFun()
        {
            strBuilder.AppendLine("protected override void Dispose(bool disposing)");
            WriteOpeningBrace();
            strBuilder.AppendLine("if (disposing && (components != null))");
            WriteOpeningBrace();
            strBuilder.AppendLine("components.Dispose();");
            WriteClosingBrace();
            strBuilder.AppendLine("base.Dispose(disposing);");
            WriteClosingBrace();
        }
        private void WriteInitializeComponentFun()
        {
            strBuilder.AppendLine("private void InitializeComponent()");
            WriteOpeningBrace();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strBuilder.AppendLine("this." + GetControlNameInitial("Label") + dt.Rows[i]["Column_Name"].ToString() + " = new " + GetControlType("Label") + "();");
                strBuilder.AppendLine("this." + GetControlNameInitial(dt.Rows[i]["Data_Type"].ToString()) + dt.Rows[i]["Column_Name"].ToString() + " = new " + GetControlType(dt.Rows[i]["Data_Type"].ToString()) + "();");
            }
            strBuilder.AppendLine("this.SuspendLayout();");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                WriteControlPropert(dt.Rows[i]["Column_Name"].ToString(), "Label", i,12,26*i);
                WriteControlPropert(dt.Rows[i]["Column_Name"].ToString(), dt.Rows[i]["Data_Type"].ToString(), i, 130, 26 * i); 
            }
            //strBuilder.AppendLine("this.components = new System.ComponentModel.Container();");

            strBuilder.AppendLine("this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);");
            strBuilder.AppendLine("this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;");
            strBuilder.AppendLine("this.ClientSize = new System.Drawing.Size(284, 262);");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strBuilder.AppendLine("this.Controls.Add(this." + GetControlNameInitial("Label") + dt.Rows[i]["Column_Name"].ToString() + ");");
                strBuilder.AppendLine("this.Controls.Add(this." + GetControlNameInitial(dt.Rows[i]["Data_Type"].ToString()) + dt.Rows[i]["Column_Name"].ToString() + ");");
            }
            strBuilder.AppendLine("this.Name = \"" + AppSetting.preUIName + dt.TableName + AppSetting.postUIName + "\";");
            strBuilder.AppendLine("this.Text = \"" + AppSetting.preUIName + dt.TableName + AppSetting.postUIName + "\";");
            strBuilder.AppendLine("this.ResumeLayout(false);");
            strBuilder.AppendLine("this.PerformLayout();");
            WriteClosingBrace(); 
        }
        private void WriteControlDeclaration()
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strBuilder.AppendLine("private " + GetControlType("Label") + " " + GetControlNameInitial("Label") + dt.Rows[i]["Column_Name"].ToString() + ";");
                strBuilder.AppendLine("private " + GetControlType(dt.Rows[i]["Data_Type"].ToString()) + " " + GetControlNameInitial(dt.Rows[i]["Data_Type"].ToString()) + dt.Rows[i]["Column_Name"].ToString() + ";");
            }
        }
        private string GetControlType(string dataType)
        {
            string str = "";
            switch (dataType)
            {
                case "Label": str = "System.Windows.Forms.Label"; break;
                case "varchar": str = "System.Windows.Forms.TextBox"; break;
                case "numeric": str = "System.Windows.Forms.TextBox"; break;
                case "datetime": str = "System.Windows.Forms.DateTimePicker"; break;
                case "bit": str = "System.Windows.Forms.CheckBox"; break;
            }
            return str;
        }
        private string GetControlNameInitial(string dataType)
        {
            string str = "";
            switch (dataType)
            {
                case "Label": str = "lbl"; break;
                case "varchar": str = "txt"; break;
                case "numeric": str = "txt"; break;
                case "datetime": str = "dtp"; break;
                case "bit": str = "chk"; break;
            }
            return str;
        }
        private void WriteControlPropert(string colName, string dataType, int controlIndex, int leftPos, int topPos)
        {
            string controlName = GetControlNameInitial(dataType) + colName;
            strBuilder.AppendLine("this." + controlName + ".Location = new System.Drawing.Point(" + leftPos.ToString() + ", " + topPos.ToString() + ");");
            strBuilder.AppendLine("this." + controlName + ".Name = \"" + controlName + "\";");
            strBuilder.AppendLine("this." + controlName + ".Size = new System.Drawing.Size(100, 13);");
            strBuilder.AppendLine("this." + controlName + ".TabIndex = " + controlIndex.ToString() + ";");
            switch (dataType)
            {
                case "Label": strBuilder.AppendLine("this." + controlName + ".Text = "  + "\""  + controlName + "\";"); break;
                case "varchar": strBuilder.AppendLine("this." + controlName + ".Text = " + "\"" + controlName + "\";"); break;
                case "numeric": strBuilder.AppendLine("this." + controlName + ".Text = " + "\"" + controlName + "\";"); break;
                case "datetime": break;
                case "bit": strBuilder.AppendLine("this." + controlName + ".Text = " + "\"" + controlName + "\";"); break;
            }
        }
    }
}
