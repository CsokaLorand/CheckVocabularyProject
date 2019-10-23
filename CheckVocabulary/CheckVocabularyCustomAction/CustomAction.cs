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
    }
}
