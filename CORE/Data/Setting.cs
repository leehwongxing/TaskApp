using System;
using System.IO;

namespace CORE.Data
{
    public class Setting
    {
        public string CredentialPath { get; set; }

        public string AppData { get; set; }

        public bool ShowHidden { get; set; }

        public bool ShowCompleted { get; set; }

        public string LastTaskList { get; set; }

        public string ApplicationName { get; private set; }

        public Setting()
        {
            ShowCompleted = false;
            ShowHidden = false;
            ApplicationName = "TaskApp";

            var Folder = Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData);

            AppData = Path.Combine(Folder, "." + ApplicationName);

            CredentialPath = Path.Combine(AppData, "Credential");
            LastTaskList = "";
        }
    }
}