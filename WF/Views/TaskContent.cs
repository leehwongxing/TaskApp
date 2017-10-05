using CORE.Interfaces;
using Google.Apis.Tasks.v1.Data;
using System;
using System.Windows.Forms;

namespace WF.Views
{
    public partial class TaskContent : Form, IView
    {
        private ITaskController Controller { get; set; }

        private string TaskId { get; set; }

        public TaskContent()
        {
            InitializeComponent();
        }

        public void Destroy()
        {
            Controller = null;
            Dispose();
        }

        public void Display()
        {
            Visible = true;
        }

        public void Hid()
        {
            Visible = false;
        }

        public void SetContent(string Id, ITaskController Context)
        {
            if (Controller != null)
            {
                Controller.Dispose();
            }

            TaskId = Id;
            Controller = Context;

            if (string.IsNullOrEmpty(TaskId))
            {
                return;
            }

            if (Controller != null)
            {
                var Data = Controller.Get(TaskId);

                Tx_Title.Text = Data.Title;
                Tx_Content.Text = Data.Notes;
                TickCheckBox(false);

                if (Data.Due != null)
                {
                    TickCheckBox(true);

                    /// Fix lỗi UTC
                    var Date = Data.Due.Value.ToLocalTime();

                    Tp_Date.Value = Date;
                    Tp_Time.Value = Date;
                }
                else
                {
                    Tp_Date.Value = DateTime.Now.Date;
                    Tp_Time.Value.Add(DateTime.Now.TimeOfDay);
                }
            }
        }

        private void TickCheckBox(bool Value)
        {
            chk_DueDate.Checked = Value;
            Tp_Date.Enabled = Value;
            Tp_Time.Enabled = Value;
        }

        private void chk_DueDate_CheckedChanged(object sender, EventArgs e)
        {
            TickCheckBox(chk_DueDate.Checked);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tx_Title.Text) || string.IsNullOrEmpty(Tx_Content.Text))
            {
                MessageBox.Show("Tên và Nội dung công việc không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Task Data;

            if (!string.IsNullOrEmpty(TaskId))
            {
                Data = Controller.Get(TaskId);

                Data.Title = Tx_Title.Text;
                Data.Notes = Tx_Content.Text;
            }
            else
            {
                Data = new Task()
                {
                    Title = Tx_Title.Text,
                    Notes = Tx_Content.Text,
                };
            }

            if (chk_DueDate.Checked)
            {
                DateTime Date = Tp_Date.Value.Date + Tp_Time.Value.TimeOfDay;

                MessageBox.Show(Date.ToShortDateString() + Date.ToLongTimeString());

                Data.Due = Date;
            }
            else
            {
                Data.Due = null;
            }

            if (string.IsNullOrEmpty(TaskId))
            {
                Controller.Create(Data);
            }
            else
            {
                Controller.Update(Data);
            }

            Destroy();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Destroy();
        }

        private void TaskContent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Destroy();
        }
    }
}