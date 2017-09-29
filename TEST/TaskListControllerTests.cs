using CORE;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TEST
{
    [TestClass()]
    public class TaskListControllerTests
    {
        private TaskListController Stub { get; set; }

        [TestMethod()]
        public void ListTest()
        {
            Stub = new TaskListController();
            var Result = Stub.List();
            Assert.AreNotEqual(Result, null);
        }

        [TestMethod()]
        public void DictionaryTest()
        {
            Stub = new TaskListController();
            var Result = Stub.Dictionary();
        }

        [TestMethod()]
        public void GetTest()
        {
            var Id = "MTc5Nzc0ODQxMTU3NjQ5NTg5Njk6MDow";
            Stub = new TaskListController();
            var Result = Stub.Get(Id);
            Assert.AreEqual(Result.Id, Id);
        }

        [TestMethod()]
        public void CreateTest()
        {
            var Title = "Made for CreateTest";

            Stub = new TaskListController();
            var Result = Stub.Create(Title);
            Assert.AreEqual(Title, Result.Title);
            Stub.Delete(Result.Id);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception), "TaskList's Title shouldnt be empty")]
        public void CreateTestFail()
        {
            var Title = "";

            Stub = new TaskListController();
            var Result = Stub.Create(Title);
            Assert.AreEqual(Title, Result.Title);
            Stub.Delete(Result.Id);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var Id = "MTc5Nzc0ODQxMTU3NjQ5NTg5Njk6MDow";
            var NewName = "New name for UpdateTest";
            Stub = new TaskListController();
            var Result = Stub.Get(Id);
            Assert.AreEqual(Result.Id, Id);
            Result.Title = NewName;

            var Updated = Stub.Update(Result);
            Assert.AreEqual(Updated.Title, NewName);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception), "TaskList not found")]
        public void DeleteTest()
        {
            var Title = "Made for CreateTest";

            Stub = new TaskListController();
            var Result = Stub.Create(Title);
            Assert.AreEqual(Title, Result.Title);
            Stub.Delete(Result.Id);

            Stub.Get(Result.Id);
        }

        [TestMethod()]
        public void GetTaskControllerTest()
        {
            var Id = "MTc5Nzc0ODQxMTU3NjQ5NTg5Njk6MDow";
            Stub = new TaskListController();
            var Controller = Stub.GetTaskController(Id);
            Assert.AreEqual(Id, Controller.TaskListId);
        }
    }
}