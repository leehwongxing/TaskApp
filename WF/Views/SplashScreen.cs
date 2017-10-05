using System.Windows.Forms;

namespace WF.Views
{
    public partial class SplashScreen : Form, IView
    {
        private Timer Clock { get; set; }

        public SplashScreen()
        {
            InitializeComponent();

            CORE.Dashboard.Get.Fetch();
        }

        private void Clock_Tick(object sender, System.EventArgs e)
        {
            Clock.Stop();

            var Dashboard = CORE.Dashboard.Get;
            var Controller = Views.Controller.Get;

            Controller.Splash.Hid();
            Controller.TaskList.SetController(Dashboard.SignIn());
            Controller.TaskList.Display();
            Dashboard.Save();
        }

        public void Display()
        {
            Visible = true;

            Clock = new Timer
            {
                Enabled = true,
                Interval = 3000
            };
            Clock.Tick += Clock_Tick;
            Clock.Start();
        }

        public void Hid()
        {
            Visible = false;
            Clock.Stop();
        }

        public void Destroy()
        {
            Dispose();
        }

        private void lb_Exit_Click(object sender, System.EventArgs e)
        {
            Program.Stop();
        }
    }
}