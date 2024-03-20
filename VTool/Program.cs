using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(!PrepareOutputPathForCodeGenerator())
                return; 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCodeGenerator());
        }
        private static bool PrepareOutputPathForCodeGenerator()
        {
            string str = System.Configuration.ConfigurationSettings.AppSettings["OutPutFilePath"];
            try
            {
                if (!System.IO.Directory.Exists(str))
                    System.IO.Directory.CreateDirectory(str);
                if (!System.IO.Directory.Exists(str + "\\InsertProc"))
                    System.IO.Directory.CreateDirectory(str + "\\InsertProc");
                if (!System.IO.Directory.Exists(str + "\\UpdateProc"))
                    System.IO.Directory.CreateDirectory(str + "\\UpdateProc");
                if (!System.IO.Directory.Exists(str + "\\ClassCode"))
                    System.IO.Directory.CreateDirectory(str + "\\ClassCode");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Please set Folder path for Output","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}