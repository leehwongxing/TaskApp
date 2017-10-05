using System;

namespace WF.Views
{
    public class Controller
    {
        private static Lazy<Controller> Controlled { get; set; }

        public TaskListView TaskList { get; private set; }

        public TaskView Task { get; private set; }

        public SplashScreen Splash { get; private set; }

        public static Controller Get { get { return Controlled.Value; } }

        static Controller()
        {
            Controlled = new Lazy<Controller>(() => new Controller());
        }

        private Controller()
        {
            TaskList = new TaskListView();
            Task = new TaskView();
            Splash = new SplashScreen();
        }
    }
}