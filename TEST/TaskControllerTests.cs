using CORE;
using Google.Apis.Tasks.v1.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TEST
{
    [TestClass()]
    public class TaskControllerTests
    {
        private TaskListController Stub { get; set; }

        private string TaskListId { get; set; }

        [TestMethod()]
        public void ListTest()
        {
            TaskListId = "MTc5Nzc0ODQxMTU3NjQ5NTg5Njk6MDow";
            Stub = new TaskListController();
            var Stick = Stub.GetTaskController(TaskListId);

            var Result = Stick.List();
            Assert.AreNotEqual(Result, null);
        }

        [TestMethod()]
        public void DictionaryTest()
        {
            TaskListId = "MTc5Nzc0ODQxMTU3NjQ5NTg5Njk6MDow";
            Stub = new TaskListController();
            var Stick = Stub.GetTaskController(TaskListId);

            var Result = Stick.Dictionary();
            Assert.AreNotEqual(Result, null);
        }

        [TestMethod()]
        public void GetTest()
        {
            var Content = new Task
            {
                Title = "Created for GetTest",
                Notes = "None"
            };

            TaskListId = "MTc5Nzc0ODQxMTU3NjQ5NTg5Njk6MDow";
            Stub = new TaskListController();
            var Stick = Stub.GetTaskController(TaskListId);
            var Result = Stick.Create(Content);
            var GetResult = Stick.Get(Result.Id);

            Assert.AreEqual(Content.Title, GetResult.Title);
            Assert.AreEqual(Content.Notes, GetResult.Notes);

            Stick.Delete(Result.Id);
        }

        [TestMethod()]
        public void CreateTest()
        {
            var Content = new Task
            {
                Title = "Created for CreateTest",
                Notes = "None"
            };

            TaskListId = "MTc5Nzc0ODQxMTU3NjQ5NTg5Njk6MDow";
            Stub = new TaskListController();
            var Stick = Stub.GetTaskController(TaskListId);
            var Result = Stick.Create(Content);

            Assert.AreEqual(Content.Title, Result.Title);
            Assert.AreEqual(Content.Notes, Result.Notes);

            Stick.Delete(Result.Id);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var Content = new Task
            {
                Title = "Created for UpdateTest",
                Notes = "None"
            };

            TaskListId = "MTc5Nzc0ODQxMTU3NjQ5NTg5Njk6MDow";
            Stub = new TaskListController();
            var Stick = Stub.GetTaskController(TaskListId);
            var Result = Stick.Create(Content);

            Result.Notes = "Updated";
            var Result2 = Stick.Update(Result);

            Assert.AreEqual(Result.Notes, Result2.Notes);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            var Content = new Task
            {
                Title = "Created for DeleteTest",
                Notes = "None"
            };

            TaskListId = "MTc5Nzc0ODQxMTU3NjQ5NTg5Njk6MDow";
            Stub = new TaskListController();
            var Stick = Stub.GetTaskController(TaskListId);
            var Result = Stick.Create(Content);

            Stick.Delete(Result.Id);
            var GetTest = Stick.Get(Result.Id);

            Assert.AreEqual(true, GetTest.Deleted);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception), "Cant move Task")]
        public void MoveToTest()
        {
            var Content = new Task
            {
                Title = "Created for DeleteTest",
                Notes = "None"
            };

            TaskListId = "MTc5Nzc0ODQxMTU3NjQ5NTg5Njk6MDow";
            Stub = new TaskListController();
            var Stick = Stub.GetTaskController(TaskListId);
            var Result = Stick.Create(Content);

            var Result2 = Stick.MoveTo(Result.Id, null);
            Assert.AreEqual(Result.Id, Result2.Id);

            Stick.Delete(Result2.Id);
            var Result3 = Stick.MoveTo(Result2.Id, "NotAnAvailableId");
        }

        [TestMethod()]
        public void ClearTest()
        {
            TaskListId = "MTc5Nzc0ODQxMTU3NjQ5NTg5Njk6MDow";
            Stub = new TaskListController();
            var Stick = Stub.GetTaskController(TaskListId);
            Stick.Clear();
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception), "Cant clear the completed Task of the TaskList")]
        public void ClearTestFail()
        {
            TaskListId = "NotReallyAvailable48648464163487987984";
            Stub = new TaskListController();
            var Stick = Stub.GetTaskController(TaskListId);
            Stick.Clear();
        }
    }
}