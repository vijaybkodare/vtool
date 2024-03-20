using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
namespace VTool
{
    static class  AppSetting
    {
        public static string namespaceName;
        public static string preClass;
        public static string postClass;
        public static string preVar;
        public static string postVar;
        public static string language;
        public static string preInsProc;
        public static string postInsProc;
        public static string preUpdProc;
        public static string postUpdProc;
        public static string preParam;
        public static string postParam;
        public static string preUIName;
        public static string postUIName;
        public static void ApplyDefaultSetting()
        {
            namespaceName = ConfigurationSettings.AppSettings["namespaceName"];
            preClass = ConfigurationSettings.AppSettings["preClass"];
            postClass = ConfigurationSettings.AppSettings["postClass"];
            preVar = ConfigurationSettings.AppSettings["preVar"];
            postVar = ConfigurationSettings.AppSettings["postVar"];
            language = ConfigurationSettings.AppSettings["language"];
            preInsProc = ConfigurationSettings.AppSettings["preInsProc"];
            postInsProc = ConfigurationSettings.AppSettings["postInsProc"];
            preUpdProc = ConfigurationSettings.AppSettings["preUpdProc"];
            postUpdProc = ConfigurationSettings.AppSettings["postUpdProc"];
            preParam = ConfigurationSettings.AppSettings["preParam"];
            postParam = ConfigurationSettings.AppSettings["postParam"];
            preUIName = ConfigurationSettings.AppSettings["preUIName"];
            postUIName = ConfigurationSettings.AppSettings["postUIName"];
        }
    }
}
