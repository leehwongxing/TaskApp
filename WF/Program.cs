using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WF
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Views.Controller.Get.Splash.Display();

            Application.Run();
        }

        public static void Stop()
        {
            CORE.Dashboard.Get.Save();

            Process.GetCurrentProcess().Kill();
        }
    }
}