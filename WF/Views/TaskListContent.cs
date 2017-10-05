using CORE.Interfaces;
using System.Windows.Forms;

namespace WF.Views
{
    public partial class TaskListContent : Form, IView
    {
        private ITaskListController Controller { get; set; }

        private string TaskListId { get; set; }

        public TaskListContent()
        {
            InitializeComponent();

            TaskListId = "";
            Controller = null;
        }

        public void Destroy()
        {
            Controller = null;
            Dispose();
        }

        public void Display()
        {
            Visible = true;

            if (string.IsNullOrEmpty(TaskListId))
            {
                Tx_Title.Text = "";
                return;
            }

            if (Controller != null)
            {
                var Data = Controller.Get(TaskListId);

                Tx_Title.Text = Data.Title;
            }

            Tx_Title.Focus();
        }

        public void Hid()
        {
            Visible = false;
        }

        public void SetContent(string Id, ITaskListController Context)
        {
            if (Controller != null)
            {
                Controller.Dispose();
            }

            Controller = Context;
            TaskListId = Id;

            if (string.IsNullOrEmpty(TaskListId))
            {
                return;
            }

            if (Controller != null)
            {
                var Data = Controller.Get(TaskListId);

                Tx_Title.Text = Data.Title;
            }
        }

        private void btn_Close_Click(object sender, System.EventArgs e)
        {
            Destroy();
        }

        private void TaskListContent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Destroy();
        }

        private void btn_Save_Click(object sender, System.EventArgs e)
        {
            if (Controller == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(Tx_Title.Text))
            {
                MessageBox.Show("Tên của danh mục công việc không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(TaskListId))
            {
                Controller.Create(Tx_Title.Text);
            }
            else
            {
                var Data = Controller.Get(TaskListId);
                Data.Title = Tx_Title.Text;

                Controller.Update(Data);
            }

            Destroy();
        }
    }
}