using CORE.Interfaces;
using System;
using System.Windows.Forms;

namespace WF.Views
{
    public partial class TaskListView : Form, IView
    {
        private ITaskListController Controller { get; set; }

        public TaskListView()
        {
            InitializeComponent();
            Hid();
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

        public void SetController(ITaskListController Context)
        {
            if (Controller != null)
            {
                Controller.Dispose();
            }

            Controller = Context;
        }

        private void Menu_ExitFromTaskListView_Click(object sender, System.EventArgs e)
        {
            Program.Stop();
        }

        private void TaskListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Program.Stop();
        }

        private void Menu_SignOut_Click(object sender, System.EventArgs e)
        {
            Hid();
            CORE.Dashboard.Get.SignOut();
            Views.Controller.Get.Splash.Display();
        }

        private void Menu_GoToTaskView_Click(object sender, System.EventArgs e)
        {
            GoToTaskView();
        }

        private void GoToTaskView()
        {
            var Selected = ListView_TaskList.SelectedItems;

            if (Selected.Count == 0)
            {
                MessageBox.Show("Chưa có đối tượng được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CORE.Dashboard.Get.Configure.LastTaskList = Selected[0].Text;
            var TaskController = Controller.GetTaskController(Selected[0].Text);
            var ViewController = Views.Controller.Get;

            Hid();
            ViewController.Task.SetController(TaskController);
            ViewController.Task.Display();
        }

        private void RefreshTaskList()
        {
            ListView_TaskList.Items.Clear();
            var Data = Controller.List();

            if (Data == null)
            {
                return;
            }
            foreach (var Item in Data)
            {
                ListView_TaskList.Items.Add(new ListViewItem(new string[] { Item.Id, Item.Title }));
            }
        }

        private void ListView_TaskList_DoubleClick(object sender, System.EventArgs e)
        {
            GoToTaskView();
        }

        private void Menu_CreateNewTaskList_Click(object sender, System.EventArgs e)
        {
            var NewContentDialog = new TaskListContent();
            NewContentDialog.SetContent("", Controller);

            NewContentDialog.ShowDialog(this);
            RefreshTaskList();
        }

        private void Menu_EditTaskList_Click(object sender, System.EventArgs e)
        {
            var Selected = ListView_TaskList.SelectedItems;

            if (Selected.Count == 0)
            {
                MessageBox.Show("Chưa có đối tượng được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var Dialog = new TaskListContent();
            Dialog.SetContent(Selected[0].Text, Controller);
            Dialog.ShowDialog(this);
            RefreshTaskList();
        }

        private void DeleteTaskList_Click(object sender, System.EventArgs e)
        {
            var Selected = ListView_TaskList.SelectedItems;

            if (Selected.Count == 0)
            {
                MessageBox.Show("Chưa có đối tượng được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var Result = MessageBox.Show("Bạn có muốn xóa danh mục công việc này", "Bạn có muốn xóa?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                try
                {
                    Controller.Delete(Selected[0].Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa được danh sách công việc này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                RefreshTaskList();
            }
        }
    }
}