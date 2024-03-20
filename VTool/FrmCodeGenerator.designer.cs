namespace VTool
{
    partial class FrmCodeGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panSelector = new System.Windows.Forms.Panel();
            this.tabSetting = new System.Windows.Forms.TabControl();
            this.tabAppSetting = new System.Windows.Forms.TabPage();
            this.chkClassCodeCCL = new System.Windows.Forms.CheckBox();
            this.chkClassCodeENT = new System.Windows.Forms.CheckBox();
            this.chkUpdateSP = new System.Windows.Forms.CheckBox();
            this.chkInsertSP = new System.Windows.Forms.CheckBox();
            this.tabClassSetting = new System.Windows.Forms.TabPage();
            this.cmbLang = new System.Windows.Forms.ComboBox();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.txtPostVar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPreVar = new System.Windows.Forms.TextBox();
            this.txtPostClass = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPreClass = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabProcedureSetting = new System.Windows.Forms.TabPage();
            this.txtPostParam = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrePara = new System.Windows.Forms.TextBox();
            this.txtPostUpd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPreUpdate = new System.Windows.Forms.TextBox();
            this.txtPostIns = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPreInsert = new System.Windows.Forms.TextBox();
            this.prgsBar = new System.Windows.Forms.ProgressBar();
            this.btnGenCode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkDefaultSetting = new System.Windows.Forms.CheckBox();
            this.cmdAuthentication = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panAuth = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panHeader = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkUIGen = new System.Windows.Forms.CheckBox();
            this.panSelector.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.tabAppSetting.SuspendLayout();
            this.tabClassSetting.SuspendLayout();
            this.tabProcedureSetting.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panAuth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panSelector
            // 
            this.panSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSelector.Controls.Add(this.tabSetting);
            this.panSelector.Controls.Add(this.prgsBar);
            this.panSelector.Controls.Add(this.btnGenCode);
            this.panSelector.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panSelector.Location = new System.Drawing.Point(0, 199);
            this.panSelector.Name = "panSelector";
            this.panSelector.Size = new System.Drawing.Size(503, 222);
            this.panSelector.TabIndex = 10;
            // 
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.tabAppSetting);
            this.tabSetting.Controls.Add(this.tabClassSetting);
            this.tabSetting.Controls.Add(this.tabProcedureSetting);
            this.tabSetting.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSetting.Location = new System.Drawing.Point(2, 1);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.SelectedIndex = 0;
            this.tabSetting.Size = new System.Drawing.Size(489, 184);
            this.tabSetting.TabIndex = 6;
            // 
            // tabAppSetting
            // 
            this.tabAppSetting.BackColor = System.Drawing.Color.FloralWhite;
            this.tabAppSetting.Controls.Add(this.chkUIGen);
            this.tabAppSetting.Controls.Add(this.chkClassCodeCCL);
            this.tabAppSetting.Controls.Add(this.chkClassCodeENT);
            this.tabAppSetting.Controls.Add(this.chkUpdateSP);
            this.tabAppSetting.Controls.Add(this.chkInsertSP);
            this.tabAppSetting.Location = new System.Drawing.Point(4, 22);
            this.tabAppSetting.Name = "tabAppSetting";
            this.tabAppSetting.Size = new System.Drawing.Size(481, 158);
            this.tabAppSetting.TabIndex = 2;
            this.tabAppSetting.Text = "Application Setting";
            // 
            // chkClassCodeCCL
            // 
            this.chkClassCodeCCL.AutoSize = true;
            this.chkClassCodeCCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkClassCodeCCL.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClassCodeCCL.Location = new System.Drawing.Point(143, 81);
            this.chkClassCodeCCL.Name = "chkClassCodeCCL";
            this.chkClassCodeCCL.Size = new System.Drawing.Size(195, 17);
            this.chkClassCodeCCL.TabIndex = 5;
            this.chkClassCodeCCL.Text = "Generate code of Class (CCL)";
            this.chkClassCodeCCL.UseVisualStyleBackColor = true;
            // 
            // chkClassCodeENT
            // 
            this.chkClassCodeENT.AutoSize = true;
            this.chkClassCodeENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkClassCodeENT.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClassCodeENT.Location = new System.Drawing.Point(143, 58);
            this.chkClassCodeENT.Name = "chkClassCodeENT";
            this.chkClassCodeENT.Size = new System.Drawing.Size(193, 17);
            this.chkClassCodeENT.TabIndex = 5;
            this.chkClassCodeENT.Text = "Generate code of Class (ENT)";
            this.chkClassCodeENT.UseVisualStyleBackColor = true;
            // 
            // chkUpdateSP
            // 
            this.chkUpdateSP.AutoSize = true;
            this.chkUpdateSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkUpdateSP.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateSP.Location = new System.Drawing.Point(143, 35);
            this.chkUpdateSP.Name = "chkUpdateSP";
            this.chkUpdateSP.Size = new System.Drawing.Size(217, 17);
            this.chkUpdateSP.TabIndex = 4;
            this.chkUpdateSP.Text = "Generate Update Store Procedure";
            this.chkUpdateSP.UseVisualStyleBackColor = true;
            // 
            // chkInsertSP
            // 
            this.chkInsertSP.AutoSize = true;
            this.chkInsertSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkInsertSP.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInsertSP.Location = new System.Drawing.Point(143, 12);
            this.chkInsertSP.Name = "chkInsertSP";
            this.chkInsertSP.Size = new System.Drawing.Size(211, 17);
            this.chkInsertSP.TabIndex = 3;
            this.chkInsertSP.Text = "Generate Insert Store Procedure";
            this.chkInsertSP.UseVisualStyleBackColor = true;
            // 
            // tabClassSetting
            // 
            this.tabClassSetting.BackColor = System.Drawing.Color.FloralWhite;
            this.tabClassSetting.Controls.Add(this.cmbLang);
            this.tabClassSetting.Controls.Add(this.txtNamespace);
            this.tabClassSetting.Controls.Add(this.txtPostVar);
            this.tabClassSetting.Controls.Add(this.label17);
            this.tabClassSetting.Controls.Add(this.label18);
            this.tabClassSetting.Controls.Add(this.txtPreVar);
            this.tabClassSetting.Controls.Add(this.txtPostClass);
            this.tabClassSetting.Controls.Add(this.label15);
            this.tabClassSetting.Controls.Add(this.label16);
            this.tabClassSetting.Controls.Add(this.txtPreClass);
            this.tabClassSetting.Controls.Add(this.label14);
            this.tabClassSetting.Controls.Add(this.label13);
            this.tabClassSetting.Location = new System.Drawing.Point(4, 22);
            this.tabClassSetting.Name = "tabClassSetting";
            this.tabClassSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabClassSetting.Size = new System.Drawing.Size(481, 104);
            this.tabClassSetting.TabIndex = 0;
            this.tabClassSetting.Text = "Class Settings";
            this.tabClassSetting.UseVisualStyleBackColor = true;
            // 
            // cmbLang
            // 
            this.cmbLang.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLang.FormattingEnabled = true;
            this.cmbLang.Items.AddRange(new object[] {
            "Language: VB.Net",
            "Language: C#.Net"});
            this.cmbLang.Location = new System.Drawing.Point(336, 5);
            this.cmbLang.Name = "cmbLang";
            this.cmbLang.Size = new System.Drawing.Size(137, 21);
            this.cmbLang.TabIndex = 33;
            // 
            // txtNamespace
            // 
            this.txtNamespace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamespace.Location = new System.Drawing.Point(97, 6);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(127, 21);
            this.txtNamespace.TabIndex = 32;
            // 
            // txtPostVar
            // 
            this.txtPostVar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostVar.Location = new System.Drawing.Point(336, 58);
            this.txtPostVar.Name = "txtPostVar";
            this.txtPostVar.Size = new System.Drawing.Size(137, 21);
            this.txtPostVar.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(230, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "+Table Field+";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Variable Name";
            // 
            // txtPreVar
            // 
            this.txtPreVar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreVar.Location = new System.Drawing.Point(97, 58);
            this.txtPreVar.Name = "txtPreVar";
            this.txtPreVar.Size = new System.Drawing.Size(127, 21);
            this.txtPreVar.TabIndex = 28;
            // 
            // txtPostClass
            // 
            this.txtPostClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostClass.Location = new System.Drawing.Point(336, 32);
            this.txtPostClass.Name = "txtPostClass";
            this.txtPostClass.Size = new System.Drawing.Size(137, 21);
            this.txtPostClass.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(230, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "+Class Name+";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Class Name";
            // 
            // txtPreClass
            // 
            this.txtPreClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreClass.Location = new System.Drawing.Point(97, 32);
            this.txtPreClass.Name = "txtPreClass";
            this.txtPreClass.Size = new System.Drawing.Size(127, 21);
            this.txtPreClass.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(245, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Language";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Namespace";
            // 
            // tabProcedureSetting
            // 
            this.tabProcedureSetting.BackColor = System.Drawing.Color.FloralWhite;
            this.tabProcedureSetting.Controls.Add(this.txtPostParam);
            this.tabProcedureSetting.Controls.Add(this.label11);
            this.tabProcedureSetting.Controls.Add(this.label12);
            this.tabProcedureSetting.Controls.Add(this.txtPrePara);
            this.tabProcedureSetting.Controls.Add(this.txtPostUpd);
            this.tabProcedureSetting.Controls.Add(this.label9);
            this.tabProcedureSetting.Controls.Add(this.label10);
            this.tabProcedureSetting.Controls.Add(this.txtPreUpdate);
            this.tabProcedureSetting.Controls.Add(this.txtPostIns);
            this.tabProcedureSetting.Controls.Add(this.label8);
            this.tabProcedureSetting.Controls.Add(this.label7);
            this.tabProcedureSetting.Controls.Add(this.txtPreInsert);
            this.tabProcedureSetting.Location = new System.Drawing.Point(4, 22);
            this.tabProcedureSetting.Name = "tabProcedureSetting";
            this.tabProcedureSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcedureSetting.Size = new System.Drawing.Size(481, 104);
            this.tabProcedureSetting.TabIndex = 1;
            this.tabProcedureSetting.Text = "Procedure Setting";
            this.tabProcedureSetting.UseVisualStyleBackColor = true;
            // 
            // txtPostParam
            // 
            this.txtPostParam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostParam.Location = new System.Drawing.Point(387, 58);
            this.txtPostParam.Name = "txtPostParam";
            this.txtPostParam.Size = new System.Drawing.Size(88, 21);
            this.txtPostParam.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(244, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "+Table Field Name+";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Parameter Name";
            // 
            // txtPrePara
            // 
            this.txtPrePara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrePara.Location = new System.Drawing.Point(149, 58);
            this.txtPrePara.Name = "txtPrePara";
            this.txtPrePara.Size = new System.Drawing.Size(89, 21);
            this.txtPrePara.TabIndex = 19;
            // 
            // txtPostUpd
            // 
            this.txtPostUpd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostUpd.Location = new System.Drawing.Point(387, 32);
            this.txtPostUpd.Name = "txtPostUpd";
            this.txtPostUpd.Size = new System.Drawing.Size(88, 21);
            this.txtPostUpd.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Update+Table Name+";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Update Procedure Name";
            // 
            // txtPreUpdate
            // 
            this.txtPreUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreUpdate.Location = new System.Drawing.Point(149, 32);
            this.txtPreUpdate.Name = "txtPreUpdate";
            this.txtPreUpdate.Size = new System.Drawing.Size(89, 21);
            this.txtPreUpdate.TabIndex = 15;
            // 
            // txtPostIns
            // 
            this.txtPostIns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostIns.Location = new System.Drawing.Point(387, 6);
            this.txtPostIns.Name = "txtPostIns";
            this.txtPostIns.Size = new System.Drawing.Size(88, 21);
            this.txtPostIns.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Insert+Table Name+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Insert Procedure Name";
            // 
            // txtPreInsert
            // 
            this.txtPreInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreInsert.Location = new System.Drawing.Point(149, 6);
            this.txtPreInsert.Name = "txtPreInsert";
            this.txtPreInsert.Size = new System.Drawing.Size(89, 21);
            this.txtPreInsert.TabIndex = 0;
            // 
            // prgsBar
            // 
            this.prgsBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.prgsBar.ForeColor = System.Drawing.Color.Orange;
            this.prgsBar.Location = new System.Drawing.Point(6, 191);
            this.prgsBar.Name = "prgsBar";
            this.prgsBar.Size = new System.Drawing.Size(364, 23);
            this.prgsBar.TabIndex = 5;
            // 
            // btnGenCode
            // 
            this.btnGenCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenCode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenCode.Location = new System.Drawing.Point(376, 191);
            this.btnGenCode.Name = "btnGenCode";
            this.btnGenCode.Size = new System.Drawing.Size(116, 25);
            this.btnGenCode.TabIndex = 4;
            this.btnGenCode.Text = "Generate Code";
            this.btnGenCode.UseVisualStyleBackColor = true;
            this.btnGenCode.Click += new System.EventHandler(this.btnGenCode_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.panSelector);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(51, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 423);
            this.panel1.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::VTool.Properties.Resources.Header;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(474, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 30);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "*";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkDefaultSetting);
            this.panel2.Controls.Add(this.cmdAuthentication);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnShowTable);
            this.panel2.Controls.Add(this.cmbDatabase);
            this.panel2.Controls.Add(this.cmbServer);
            this.panel2.Controls.Add(this.lstTables);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panAuth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 391);
            this.panel2.TabIndex = 28;
            // 
            // chkDefaultSetting
            // 
            this.chkDefaultSetting.AutoSize = true;
            this.chkDefaultSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDefaultSetting.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefaultSetting.Location = new System.Drawing.Point(147, 143);
            this.chkDefaultSetting.Name = "chkDefaultSetting";
            this.chkDefaultSetting.Size = new System.Drawing.Size(146, 17);
            this.chkDefaultSetting.TabIndex = 37;
            this.chkDefaultSetting.Text = "Apply default settings";
            this.chkDefaultSetting.UseVisualStyleBackColor = true;
            this.chkDefaultSetting.CheckedChanged += new System.EventHandler(this.chkDefaultSetting_CheckedChanged);
            // 
            // cmdAuthentication
            // 
            this.cmdAuthentication.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAuthentication.FormattingEnabled = true;
            this.cmdAuthentication.Items.AddRange(new object[] {
            "SQL Server Authentication",
            "Windows Authentication"});
            this.cmdAuthentication.Location = new System.Drawing.Point(112, 30);
            this.cmdAuthentication.Name = "cmdAuthentication";
            this.cmdAuthentication.Size = new System.Drawing.Size(192, 21);
            this.cmdAuthentication.TabIndex = 35;
            this.cmdAuthentication.SelectedIndexChanged += new System.EventHandler(this.cmdAuthentication_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Authentication";
            // 
            // btnShowTable
            // 
            this.btnShowTable.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTable.Location = new System.Drawing.Point(10, 140);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(105, 23);
            this.btnShowTable.TabIndex = 33;
            this.btnShowTable.Text = "Show Tables";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbDatabase.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(113, 111);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(191, 21);
            this.cmbDatabase.TabIndex = 32;
            // 
            // cmbServer
            // 
            this.cmbServer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(112, 5);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(192, 21);
            this.cmbServer.TabIndex = 31;
            // 
            // lstTables
            // 
            this.lstTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTables.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTables.FormattingEnabled = true;
            this.lstTables.Location = new System.Drawing.Point(310, 5);
            this.lstTables.Name = "lstTables";
            this.lstTables.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstTables.Size = new System.Drawing.Size(187, 158);
            this.lstTables.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Select Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select Server";
            // 
            // panAuth
            // 
            this.panAuth.Controls.Add(this.txtPassword);
            this.panAuth.Controls.Add(this.txtUserId);
            this.panAuth.Controls.Add(this.label4);
            this.panAuth.Controls.Add(this.label3);
            this.panAuth.Location = new System.Drawing.Point(2, 51);
            this.panAuth.Name = "panAuth";
            this.panAuth.Size = new System.Drawing.Size(309, 56);
            this.panAuth.TabIndex = 36;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(111, 29);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '#';
            this.txtPassword.Size = new System.Drawing.Size(191, 21);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUserId
            // 
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(111, 4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(191, 21);
            this.txtUserId.TabIndex = 22;
            this.txtUserId.Leave += new System.EventHandler(this.txtUserId_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Enter Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Enter Login ID";
            // 
            // panHeader
            // 
            this.panHeader.BackgroundImage = global::VTool.Properties.Resources.Header1;
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(503, 30);
            this.panHeader.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vritti: Developer Tool";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::VTool.Properties.Resources.Margin;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // chkUIGen
            // 
            this.chkUIGen.AutoSize = true;
            this.chkUIGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkUIGen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUIGen.Location = new System.Drawing.Point(143, 104);
            this.chkUIGen.Name = "chkUIGen";
            this.chkUIGen.Size = new System.Drawing.Size(139, 17);
            this.chkUIGen.TabIndex = 5;
            this.chkUIGen.Text = "Generate code of UI";
            this.chkUIGen.UseVisualStyleBackColor = true;
            // 
            // FrmCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Generator";
            this.Load += new System.EventHandler(this.FrmCodeGenerator_Load);
            this.panSelector.ResumeLayout(false);
            this.tabSetting.ResumeLayout(false);
            this.tabAppSetting.ResumeLayout(false);
            this.tabAppSetting.PerformLayout();
            this.tabClassSetting.ResumeLayout(false);
            this.tabClassSetting.PerformLayout();
            this.tabProcedureSetting.ResumeLayout(false);
            this.tabProcedureSetting.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panAuth.ResumeLayout(false);
            this.panAuth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panSelector;
        private System.Windows.Forms.Button btnGenCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ProgressBar prgsBar;
        private System.Windows.Forms.TabControl tabSetting;
        private System.Windows.Forms.TabPage tabClassSetting;
        private System.Windows.Forms.TabPage tabProcedureSetting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPreInsert;
        private System.Windows.Forms.TextBox txtPostIns;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPostParam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrePara;
        private System.Windows.Forms.TextBox txtPostUpd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPreUpdate;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.TextBox txtPostVar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPreVar;
        private System.Windows.Forms.TextBox txtPostClass;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPreClass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbLang;
        private System.Windows.Forms.TabPage tabAppSetting;
        private System.Windows.Forms.CheckBox chkClassCodeENT;
        private System.Windows.Forms.CheckBox chkUpdateSP;
        private System.Windows.Forms.CheckBox chkInsertSP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkDefaultSetting;
        private System.Windows.Forms.ComboBox cmdAuthentication;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panAuth;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkClassCodeCCL;
        private System.Windows.Forms.CheckBox chkUIGen;
    }
}

