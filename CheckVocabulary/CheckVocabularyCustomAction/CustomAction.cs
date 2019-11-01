using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace CheckVocabularyCustomAction
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult RegKeySetupAction(Session session)
        {
            string installDirString = session["INSTALLFOLDER"];
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\run", true);
            regKey.SetValue("CsokaApp", installDirString + "CheckVocabulary.exe");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult RegKeyCleanAction(Session session)
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "Teszt.txt");

            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\run", true);
            regKey.DeleteValue("CsokaApp");

            return ActionResult.Success;
        }
    }
}
