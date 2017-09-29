using System;

namespace CORE.Interfaces
{
    public interface IConfigure : IDisposable
    {
        ITaskListController SignIn();

        void SignOut();

        void Save();

        void Fetch();
    }
}