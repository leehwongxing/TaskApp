using Google.Apis.Tasks.v1.Data;
using System;
using System.Collections.Generic;

namespace CORE.Interfaces
{
    public interface ITaskController : IDisposable
    {
        IList<Task> List();

        Dictionary<string, Task> Dictionary();

        Task Get(string Id);

        Task Create(Task Content);

        Task Update(Task Content);

        void Delete(string Id);

        Task MoveTo(string Id, string Previous);

        void Clear();
    }
}