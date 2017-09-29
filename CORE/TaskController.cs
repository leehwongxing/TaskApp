using Google.Apis.Tasks.v1;
using Google.Apis.Tasks.v1.Data;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CORE
{
    public class TaskController : Interfaces.ITaskController
    {
        public string TaskListId { get; private set; }

        private TasksService Service { get; set; }

        public TaskController(TasksService Holder, string Id)
        {
            Service = Holder;
            TaskListId = Id;
        }

        public IList<Task> List()
        {
            var Request = Service.Tasks.List(TaskListId);
            var Result = Request.Execute().Items;

            return Result;
        }

        public Dictionary<string, Task> Dictionary()
        {
            var Content = List();
            var Result = new Dictionary<string, Task>();
            foreach (var Item in Content)
            {
                Result.Add(Item.Id, Item);
            }
            return Result;
        }

        public Task Get(string Id)
        {
            if (string.IsNullOrEmpty(Id))
            {
                throw new Exception("Task's Id cant be empty");
            }
            try
            {
                var Request = Service.Tasks.Get(TaskListId, Id);
                var Result = Request.Execute();

                return Result;
            }
            catch (Exception)
            {
                throw new Exception("Task not found");
            }
        }

        public Task Create(Task Content)
        {
            if (string.IsNullOrEmpty(Content.Title) || string.IsNullOrEmpty(Content.Notes))
            {
                throw new Exception("Title and Note of Task cant be empty");
            }

            var Request = Service.Tasks.Insert(Content, TaskListId);
            var Result = Request.Execute();
            if (Result == null)
            {
                throw new Exception("Cant create new Task on this TaskList");
            }
            return Result as Task;
        }

        public Task Update(Task Content)
        {
            if (string.IsNullOrEmpty(Content.Id))
            {
                throw new Exception("Task's Id cant be empty");
            }

            var Request = Service.Tasks.Update(Content, TaskListId, Content.Id);
            var Result = Request.Execute();

            if (Result == null)
            {
                throw new Exception("Cant update Task at" + Content.Id);
            }
            return Result as Task;
        }

        public void Delete(string Id)
        {
            if (string.IsNullOrEmpty(Id))
            {
                throw new Exception("Task's Id cant me empty");
            }

            var Request = Service.Tasks.Delete(TaskListId, Id);
            var Result = Request.Execute();

            if (!string.IsNullOrEmpty(Result))
            {
                throw new Exception("Task at " + Id + " cant be deleted");
            }
        }

        public Task MoveTo(string Id, string Previous)
        {
            var Content = Get(Id);
            var PreviousTask = (string.IsNullOrEmpty(Previous)) ? null : Get(Previous);

            var Request = Service.Tasks.Move(TaskListId, Content.Id);
            Request.Previous = PreviousTask?.Id;

            var Result = Request.Execute();
            if (Result.Id != Content.Id)
            {
                throw new Exception("Cant move Task");
            }
            return Result;
        }

        public void Clear()
        {
            try
            {
                var Request = Service.Tasks.Clear(TaskListId);
                var Result = Request.Execute();
            }
            catch (Exception)
            {
                throw new Exception("Cant clear the completed Task of the TaskList");
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
                handle.Dispose();
            }

            Service = null;
            disposed = true;
        }
    }
}