using System;
using System.IO;

namespace CORE.Data
{
    public class Setting
    {
        public string CredentialPath { get; set; }

        public string OfflineQueue { get; private set; }

        public bool ShowHidden { get; set; }

        public bool ShowCompleted { get; set; }

        public string ApplicationName { get; private set; }

        public Setting()
        {
            var ParentFolder = Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData);

            OfflineQueue = ".offline";
            ShowCompleted = true;
            ShowHidden = false;
            ApplicationName = "TaskApp";
            CredentialPath = Path.Combine(ParentFolder, "." + ApplicationName);
        }
    }
}