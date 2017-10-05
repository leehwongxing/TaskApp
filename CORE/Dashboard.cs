using CORE.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Tasks.v1;
using Google.Apis.Util.Store;
using Microsoft.Win32.SafeHandles;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace CORE
{
    public class Dashboard : IConfigure
    {
        private string Location { get; set; }

        public Data.Setting Configure { get; private set; }

        private TasksService Service { get; set; }

        private UserCredential Credential { get; set; }

        private static string[] Scopes = { TasksService.Scope.Tasks };

        private ITaskListController Controlled { get; set; }

        private static Lazy<Dashboard> LazyDashBoard { get; set; }

        public static Dashboard Get { get { return LazyDashBoard.Value; } }

        static Dashboard()
        {
            LazyDashBoard = new Lazy<Dashboard>(() => new Dashboard());
        }

        public Dashboard()
        {
            Location = ".settings";
        }

        public void Fetch()
        {
            try
            {
                using (var Context = File.Open(Path.Combine(Configure.AppData, Location), FileMode.Open, FileAccess.Read, FileShare.Read) as Stream)
                using (var Reader = new StreamReader(Context, Encoding.UTF8, true, 1024))
                {
                    var Temp = JsonConvert.DeserializeObject<Data.Setting>(Reader.ReadLine());

                    Configure = Temp;
                }
            }
            catch (Exception)
            {
                if (Configure == null)
                {
                    Configure = new Data.Setting();
                }
            }
        }

        public void Save()
        {
            try
            {
                using (var Context = File.Open(Path.Combine(Configure.AppData, Location), FileMode.Create, FileAccess.Write, FileShare.None) as Stream)
                using (var Writer = new StreamWriter(Context, Encoding.UTF8, 1024))
                {
                    Writer.WriteLine(JsonConvert.SerializeObject(Configure));
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public ITaskListController SignIn()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("CORE.client_secret.json"))
            {
                Credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "TaskAppUser",
                    CancellationToken.None,
                    new FileDataStore(Configure.CredentialPath, true)).Result;
                Console.WriteLine("Credential saved to: " + Configure.CredentialPath);

                Service = new TasksService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = Credential,
                    ApplicationName = Configure.ApplicationName,
                });
            }

            Controlled = new TaskListController(Service);

            return Controlled;
        }

        public void SignOut()
        {
            Controlled.Dispose();
            Service.Dispose();
            Credential = null;
            Service = null;

            var Path = new DirectoryInfo(Configure.CredentialPath);
            Path.CleanUp();
        }

        private bool disposed = false;
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                SignOut();
                handle.Dispose();
            }

            disposed = true;
        }
    }
}