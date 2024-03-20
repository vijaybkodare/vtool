using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient ;
using System.Data;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common ;
 
namespace VTool
{
    class DBHandler
    {
        private static SqlConnection con;
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static string conString;
        public static void  InitDataBase(string serverName, string dataBaseName, string userId, string password)
        {
            conString = "Data Source=" + serverName + ";Initial Catalog=" +
                dataBaseName + "; User ID=" + userId + ";Password=" + password;// +";Provider = SQLOLEDB";
            //conString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\vijay-imp-programs\CodeGenerator\DummyDB.mdb";
            InitObject();
        }
        
        public static void InitDataBase(string serverName, string dataBaseName)
        {
            conString = "Data Source=" + serverName + ";Initial Catalog=" + 
                dataBaseName + ";Integrated Security=True;";// Provider=SQLOLEDB";
            //conString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\vijay-imp-programs\CodeGenerator\DummyDB.mdb";
            InitObject();
        }

        private static void InitObject()
        {
           // conString = "Data Source=VSD08;Initial Catalog=master;User ID=sa; password=sa";
            con = new SqlConnection (conString);
            cmd = new SqlCommand ("", con);
            da = new SqlDataAdapter (cmd);
        }

        public static DataTable GetTableWithSchema(string tableName)
        {
            //tableName = "studentmaster";
            DataTable dt  = new DataTable ();
            cmd.CommandText = "SELECT Column_Name, Data_Type, Character_Maximum_Length," +
              "Numeric_Precision, Numeric_Scale FROM INFORMATION_SCHEMA.COLUMNS " + 
                " WHERE Table_Name = '" + tableName + "'";
            da.Fill(dt);
            dt.TableName =tableName ;
            return dt;
        }

        public static string[] GetServerList()
        {
            DataTable dt = SmoApplication.EnumAvailableSqlServers();
            string[] str = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
                str[i] = dt.Rows[i][0].ToString();
            return str;//           return new string[4]; 
        }

        public static string[] GetDataBaseList(string serverName, string userId, string password)
        {
            Server sqlServer = new Server();
            sqlServer.ConnectionContext.ServerInstance = serverName;
            sqlServer.ConnectionContext.LoginSecure = false;
            sqlServer.ConnectionContext.Login =  userId;
            sqlServer.ConnectionContext.Password = password;
            sqlServer.ConnectionContext.Connect();
            string[] str = new string[sqlServer.Databases.Count];
            for (int i = 0; i < sqlServer.Databases.Count; i++)
                str[i] = sqlServer.Databases[i].Name;
            return str;
            //return new string[4];
        }
        
        public static string[] GetDataBaseList(string serverName)
        {
            Server sqlServer = new Server();
            sqlServer.ConnectionContext.ServerInstance = serverName;
            sqlServer.ConnectionContext.Connect();
            string[] str = new string[sqlServer.Databases.Count];
            for (int i = 0; i < sqlServer.Databases.Count; i++)
                str[i] = sqlServer.Databases[i].Name;
            return str;
            //return new string[4];
        }
        public static string[] GetTableList()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT table_name FROM INFORMATION_SCHEMA.Tables " +
                "WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY table_name";
            da.Fill(dt);
            string[] str = new string[dt.Rows.Count];
            for (int i=0; i < dt.Rows.Count ; i++)
                str[i] = dt.Rows[i][0].ToString(); 
            return str ;
        }
    }
}
