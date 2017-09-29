using Google.Apis.Tasks.v1.Data;
using System;
using System.Collections.Generic;

namespace CORE.Interfaces
{
    public interface ITaskListController : IDisposable
    {
        IList<TaskList> List();

        Dictionary<string, TaskList> Dictionary();

        TaskList Get(string Id);

        TaskList Create(string Title);

        TaskList Update(TaskList Content);

        void Delete(string Id);

        ITaskController GetTaskController(string Id);
    }
}