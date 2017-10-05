using CORE.Interfaces;
using System.Windows.Forms;

namespace WF.Views
{
    public partial class TaskView : Form, IView
    {
        private ITaskController Controller { get; set; }

        public TaskView()
        {
            InitializeComponent();

            Visible = false;
        }

        public void Destroy()
        {
            Controller.Dispose();
            Dispose();
        }

        public void Display()
        {
            Visible = true;

            RefreshTaskList();
        }

        public void Hid()
        {
            Visible = false;
        }

        public void SetController(ITaskController Context)
        {
            if (Controller != null)
            {
                Controller.Dispose();
            }

            Controller = Context;
        }

        private void RefreshTaskList()
        {
            var Data = Controller.List();

            ListView_Task.Items.Clear();
            if (Data == null)
            {
                return;
            }
            foreach (var Item in Data)
            {
                ListView_Task.Items.Add(new ListViewItem(new string[] { Item.Id, Item.Title }));
            }
        }

        private void Menu_ExitFromTaskView_Click(object sender, System.EventArgs e)
        {
            Program.Stop();
        }

        private void Menu_ReturnToTaskListView_Click(object sender, System.EventArgs e)
        {
            var ViewController = Views.Controller.Get;

            Hid();
            ViewController.TaskList.Display();
        }

        private void Menu_AddNewTask_Click(object sender, System.EventArgs e)
        {
            var Dialog = new TaskContent();
            Dialog.SetContent("", Controller);
            Dialog.ShowDialog(this);

            RefreshTaskList();
        }

        private void Menu_EditTask_Click(object sender, System.EventArgs e)
        {
            var Selected = ListView_Task.SelectedItems;

            if (Selected.Count == 0)
            {
                MessageBox.Show("Chưa có đối tượng được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var Dialog = new TaskContent();
            Dialog.SetContent(Selected[0].Text, Controller);
            Dialog.ShowDialog(this);

            RefreshTaskList();
        }

        private void Menu_DeleteTask_Click(object sender, System.EventArgs e)
        {
            var Selected = ListView_Task.SelectedItems;

            if (Selected.Count == 0)
            {
                MessageBox.Show("Chưa có đối tượng được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var Result = MessageBox.Show("Bạn có muốn xóa công việc này?", "Bạn có muốn xóa?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                Controller.Delete(Selected[0].Text);
                RefreshTaskList();
            }
        }

        private void Menu_FinishedTask_Click(object sender, System.EventArgs e)
        {
            var Selected = ListView_Task.SelectedItems;

            if (Selected.Count == 0)
            {
                MessageBox.Show("Chưa có đối tượng được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void ListView_Task_DoubleClick(object sender, System.EventArgs e)
        {
            var Selected = ListView_Task.SelectedItems;

            if (Selected.Count == 0)
            {
                MessageBox.Show("Chưa có đối tượng được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var Dialog = new TaskContent();
            Dialog.SetContent(Selected[0].Text, Controller);
            Dialog.ShowDialog(this);

            RefreshTaskList();
        }

        private void TaskView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hid();
            Views.Controller.Get.TaskList.Display();
        }
    }
}