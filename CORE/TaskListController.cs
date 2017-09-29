using Google.Apis.Tasks.v1;
using Google.Apis.Tasks.v1.Data;
using System;
using System.Collections.Generic;
using CORE.Interfaces;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace CORE
{
    public class TaskListController : ITaskListController
    {
        private TasksService Service { get; set; }

        private Dictionary<string, ITaskController> Controlled { get; set; }

        public TaskListController(TasksService Holder)
        {
            Service = Holder;
            Controlled = new Dictionary<string, ITaskController>();
        }

        public IList<TaskList> List()
        {
            var Request = Service.Tasklists.List();
            var Result = Request.Execute().Items;
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

        public ITaskController GetTaskController(string Id)
        {
            Controlled.TryGetValue(Id, out ITaskController found);

            if (found == null)
            {
                var Result = Get(Id);
                var Controller = new TaskController(Service, Result.Id);

                Controlled.Add(Id, Controller);
                return Controller;
            }
            else
            {
                return found;
            }
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
                foreach (var Item in Controlled)
                {
                    Item.Value.Dispose();
                }
                Controlled.Clear();
                handle.Dispose();
            }

            Service = null;
            disposed = true;
        }
    }
}