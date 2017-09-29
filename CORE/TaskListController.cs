using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Tasks.v1;
using Google.Apis.Tasks.v1.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;

namespace CORE
{
    public class TaskListController
    {
        private TasksService Service { get; set; }

        private UserCredential Credential { get; set; }

        private static string[] Scopes = { TasksService.Scope.Tasks };

        private static string ApplicationName = "TaskApp";

        public TaskListController()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("CORE.client_secret.json"))
            {
                string CredentialPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.LocalApplicationData);
                CredentialPath = Path.Combine(CredentialPath, "." + ApplicationName);

                Credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(CredentialPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + CredentialPath);

                Service = new TasksService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = Credential,
                    ApplicationName = ApplicationName,
                });
            }
        }

        public IList<TaskList> List()
        {
            var Request = Service.Tasklists.List();
            var Result = Request.Execute().Items;
            Console.WriteLine(Result.Count + " item has been listed");
            return Result;
        }

        public Dictionary<string, TaskList> Dictionary()
        {
            var Content = List();
            var Result = new Dictionary<string, TaskList>();
            foreach (var Item in Content)
            {
                Result.Add(Item.Id, Item);
            }
            Console.WriteLine(Result.Count + " item has been added");
            return Result;
        }

        public TaskList Get(string Id)
        {
            if (string.IsNullOrEmpty(Id))
            {
                throw new Exception("TaskList's Id cant be null");
            }
            try
            {
                var Request = Service.Tasklists.Get(Id);
                var Result = Request.Execute();

                return Result;
            }
            catch (Exception)
            {
                throw new Exception("TaskList not found");
            }
        }

        public TaskList Create(string Title)
        {
            if (string.IsNullOrEmpty(Title))
            {
                throw new Exception("TaskList's Title shouldnt be empty");
            }
            var Content = new TaskList
            {
                Title = Title
            };
            var Request = Service.Tasklists.Insert(Content);
            var Result = Request.Execute();

            return Result;
        }

        public TaskList Update(TaskList Content)
        {
            if (string.IsNullOrEmpty(Content.Id))
            {
                throw new Exception("ID of TaskList cant be empty");
            }
            var Request = Service.Tasklists.Update(Content, Content.Id);
            var Result = Request.Execute();

            return Result as TaskList;
        }

        public void Delete(string Id)
        {
            if (string.IsNullOrEmpty(Id))
            {
                throw new Exception("ID of TaskList cant be empty");
            }
            var Content = new TaskList
            {
                Id = Id
            };
            var Request = Service.Tasklists.Delete(Id);
            var Result = Request.Execute();

            if (!string.IsNullOrEmpty(Result))
            {
                throw new Exception("Cant delete TaskList at " + Content.Id + " \r\n" + Result);
            }
        }

        public TaskController GetTaskController(string Id)
        {
            var Result = Get(Id);
            return new TaskController(Service, Result.Id);
        }
    }
}