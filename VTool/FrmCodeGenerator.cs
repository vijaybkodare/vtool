using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VTool
{
    public partial class FrmCodeGenerator : Form
    {
        public FrmCodeGenerator()
        {
            InitializeComponent();
        }
        #region User defined Function

        private void RunCodeGenerator()
        {
            ApplyApplicationSetting();
            prgsBar.Value = 0;
            prgsBar.Maximum = lstTables.SelectedItems.Count;
            ClsInsertStorProcGenerator insStoProcGen = new ClsInsertStorProcGenerator();
            ClsUpdateStorProcGenerator updStorProcGen = new ClsUpdateStorProcGenerator();
            ClsENTClassCodeGenerator clsENTCodeGenerator = new ClsENTClassCodeGenerator();
            ClsCCLClassCodeGenerator clsCCLCodeGenerator = new ClsCCLClassCodeGenerator();
            ClsUIGeneratorMain clsUICodeGen = new ClsUIGeneratorMain();
            ClsUIGeneratorDesig clsUICodeGenDes = new ClsUIGeneratorDesig();
            for (int i = 0; i < lstTables.SelectedItems.Count; i++)
            {
                if (chkInsertSP.Checked)
                    insStoProcGen.GenerateStoreProcedure(lstTables.SelectedItems[i].ToString());
                if (chkUpdateSP.Checked)
                    updStorProcGen.GenerateStoreProcedure(lstTables.SelectedItems[i].ToString());
                if (chkClassCodeENT.Checked)
                    clsENTCodeGenerator.GenerateClassCode(lstTables.SelectedItems[i].ToString());
                if (chkClassCodeCCL.Checked)
                    clsCCLCodeGenerator.GenerateClassCode(lstTables.SelectedItems[i].ToString());
                if (chkUIGen.Checked)
                {
                    clsUICodeGen.GenerateCode(lstTables.SelectedItems[i].ToString());
                    clsUICodeGenDes.GenerateCode(lstTables.SelectedItems[i].ToString());
                }
                prgsBar.Value += 1;
            }
            MessageBox.Show("Code generated successfully at " + System.Configuration.ConfigurationSettings.AppSettings["OutPutFilePath"].ToString(),
                 "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            prgsBar.Value = 0;
        }
        private void ApplyApplicationSetting()
        {
            if (chkDefaultSetting.Checked)
            {
                AppSetting.ApplyDefaultSetting();
                return;
            }
            AppSetting.namespaceName = txtNamespace.Text.Trim();
            AppSetting.preClass = txtPreClass.Text.Trim();
            AppSetting.postClass = txtPostClass.Text.Trim();
            AppSetting.preVar = txtPreVar.Text.Trim();
            AppSetting.postVar = txtPostVar.Text.Trim();
            AppSetting.language = cmbLang.Text;
            AppSetting.preInsProc = txtPreInsert.Text.Trim();
            AppSetting.postInsProc = txtPostIns.Text.Trim();
            AppSetting.preUpdProc = txtPreUpdate.Text.Trim();
            AppSetting.postUpdProc = txtPostUpd.Text.Trim();
            AppSetting.preParam = txtPrePara.Text.Trim();
            AppSetting.postParam = txtPostParam.Text.Trim();
        }
        private void PopulateServerList()
        {
            cmbServer.DataSource = DBHandler.GetServerList();
        }

        private void PopulateDatabaseList(string serverName)
        {
            try
            {
                cmbDatabase.DataSource = DBHandler.GetDataBaseList(serverName);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateDatabaseList(string serverName, string loginName, string password)
        {
            try
            {
                cmbDatabase.DataSource = DBHandler.GetDataBaseList(serverName, loginName, password);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DisplayTableList()
        {
            if (panAuth.Enabled == true)
                DBHandler.InitDataBase(cmbServer.Text, cmbDatabase.Text, txtUserId.Text, txtPassword.Text);
            else
                DBHandler.InitDataBase(cmbServer.Text, cmbDatabase.Text);
            try
            {
                lstTables.DataSource = DBHandler.GetTableList();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to connect Server " + cmbServer.Text, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void SetEnabilityOfClassProcSettingControl(bool enable)
        {
            enable = !enable;
            cmbLang.Enabled = enable;
            txtNamespace.Enabled = enable;
            txtPostClass.Enabled = enable;
            txtPostIns.Enabled = enable;
            txtPostParam.Enabled = enable;
            txtPostUpd.Enabled = enable;
            txtPostVar.Enabled = enable;
            txtPreClass.Enabled = enable;
            txtPreInsert.Enabled = enable;
            txtPrePara.Enabled = enable;
            txtPreUpdate.Enabled = enable;
            txtPreVar.Enabled = enable;
        }
        private void SetDefaultData()
        {
            cmbServer.Text = System.Configuration.ConfigurationSettings.AppSettings["Server"].ToString();
            txtUserId .Text = System.Configuration.ConfigurationSettings.AppSettings["UserID"].ToString();
            txtPassword.Text = System.Configuration.ConfigurationSettings.AppSettings["Password"].ToString();
            cmbDatabase.Text = System.Configuration.ConfigurationSettings.AppSettings["Database"].ToString();
            chkClassCodeCCL.Checked = true;
            chkClassCodeENT.Checked = true;
            chkInsertSP.Checked = true;
            chkUpdateSP.Checked = true;
        }
        private void DisplayTable()
        {
            if (DisplayTableList())
                btnGenCode.Enabled = true;
            else
                btnGenCode.Enabled = true;
        }
        #endregion
        
        #region Control Events
        private void FrmCodeGenerator_Load(object sender, EventArgs e)
        {
            cmdAuthentication.SelectedIndex = 0;
            cmbLang.SelectedIndex = 0;
            chkDefaultSetting.Checked = true;
            btnGenCode.Enabled = false;  
            PopulateServerList();
            SetDefaultData();
            DisplayTable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            DisplayTable();
        }
        private void cmdAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdAuthentication.SelectedIndex == 1)
            {
                panAuth.Enabled = false;
                PopulateDatabaseList(cmbServer.Text);
            }
            else
                panAuth.Enabled = true;
        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            txtPassword.SelectAll  ();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            PopulateDatabaseList(cmbServer.Text, txtUserId.Text, txtPassword.Text);
        }

        private void btnGenCode_Click(object sender, EventArgs e)
        {
            RunCodeGenerator();
        }

        private void chkDefaultSetting_CheckedChanged(object sender, EventArgs e)
        {
            SetEnabilityOfClassProcSettingControl(chkDefaultSetting.Checked);
        }
        #endregion

        

        

    }
}