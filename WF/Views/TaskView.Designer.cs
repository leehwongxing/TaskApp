namespace WF.Views
{
    partial class TaskView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskView));
            this.Task_Menu = new System.Windows.Forms.MenuStrip();
            this.chươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ReturnToTaskListView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_ExitFromTaskView = new System.Windows.Forms.ToolStripMenuItem();
            this.côngViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_AddNewTask = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_EditTask = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_FinishedTask = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DeleteTask = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.ListView_Task = new System.Windows.Forms.ListView();
            this.TaskId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Task_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Task_Menu
            // 
            this.Task_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chươngTrìnhToolStripMenuItem,
            this.côngViệcToolStripMenuItem});
            this.Task_Menu.Location = new System.Drawing.Point(0, 0);
            this.Task_Menu.Name = "Task_Menu";
            this.Task_Menu.Size = new System.Drawing.Size(264, 24);
            this.Task_Menu.TabIndex = 0;
            this.Task_Menu.Text = "menuStrip1";
            // 
            // chươngTrìnhToolStripMenuItem
            // 
            this.chươngTrìnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_ReturnToTaskListView,
            this.toolStripSeparator1,
            this.Menu_ExitFromTaskView});
            this.chươngTrìnhToolStripMenuItem.Name = "chươngTrìnhToolStripMenuItem";
            this.chươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.chươngTrìnhToolStripMenuItem.Text = "Chương trình";
            // 
            // Menu_ReturnToTaskListView
            // 
            this.Menu_ReturnToTaskListView.Name = "Menu_ReturnToTaskListView";
            this.Menu_ReturnToTaskListView.Size = new System.Drawing.Size(217, 22);
            this.Menu_ReturnToTaskListView.Text = "Trở về danh mục công việc";
            this.Menu_ReturnToTaskListView.Click += new System.EventHandler(this.Menu_ReturnToTaskListView_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // Menu_ExitFromTaskView
            // 
            this.Menu_ExitFromTaskView.Name = "Menu_ExitFromTaskView";
            this.Menu_ExitFromTaskView.Size = new System.Drawing.Size(217, 22);
            this.Menu_ExitFromTaskView.Text = "Thoát chương trình";
            this.Menu_ExitFromTaskView.Click += new System.EventHandler(this.Menu_ExitFromTaskView_Click);
            // 
            // côngViệcToolStripMenuItem
            // 
            this.côngViệcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_AddNewTask,
            this.toolStripSeparator2,
            this.Menu_EditTask,
            this.Menu_FinishedTask,
            this.Menu_DeleteTask});
            this.côngViệcToolStripMenuItem.Name = "côngViệcToolStripMenuItem";
            this.côngViệcToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.côngViệcToolStripMenuItem.Text = "Công việc";
            // 
            // Menu_AddNewTask
            // 
            this.Menu_AddNewTask.Name = "Menu_AddNewTask";
            this.Menu_AddNewTask.Size = new System.Drawing.Size(183, 22);
            this.Menu_AddNewTask.Text = "Thêm công việc mới";
            this.Menu_AddNewTask.Click += new System.EventHandler(this.Menu_AddNewTask_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // Menu_EditTask
            // 
            this.Menu_EditTask.Name = "Menu_EditTask";
            this.Menu_EditTask.Size = new System.Drawing.Size(183, 22);
            this.Menu_EditTask.Text = "Chỉnh sửa";
            this.Menu_EditTask.Click += new System.EventHandler(this.Menu_EditTask_Click);
            // 
            // Menu_FinishedTask
            // 
            this.Menu_FinishedTask.Enabled = false;
            this.Menu_FinishedTask.Name = "Menu_FinishedTask";
            this.Menu_FinishedTask.Size = new System.Drawing.Size(183, 22);
            this.Menu_FinishedTask.Text = "Hoàn thành";
            this.Menu_FinishedTask.Click += new System.EventHandler(this.Menu_FinishedTask_Click);
            // 
            // Menu_DeleteTask
            // 
            this.Menu_DeleteTask.Name = "Menu_DeleteTask";
            this.Menu_DeleteTask.Size = new System.Drawing.Size(183, 22);
            this.Menu_DeleteTask.Text = "Xóa";
            this.Menu_DeleteTask.Click += new System.EventHandler(this.Menu_DeleteTask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Các công việc";
            // 
            // ListView_Task
            // 
            this.ListView_Task.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView_Task.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TaskId,
            this.Title});
            this.ListView_Task.FullRowSelect = true;
            this.ListView_Task.GridLines = true;
            this.ListView_Task.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView_Task.Location = new System.Drawing.Point(12, 93);
            this.ListView_Task.Name = "ListView_Task";
            this.ListView_Task.Size = new System.Drawing.Size(240, 356);
            this.ListView_Task.TabIndex = 12;
            this.ListView_Task.UseCompatibleStateImageBehavior = false;
            this.ListView_Task.View = System.Windows.Forms.View.Details;
            this.ListView_Task.DoubleClick += new System.EventHandler(this.ListView_Task_DoubleClick);
            // 
            // TaskId
            // 
            this.TaskId.Width = 0;
            // 
            // Title
            // 
            this.Title.Text = "Công việc";
            this.Title.Width = 240;
            // 
            // TaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 461);
            this.Controls.Add(this.ListView_Task);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Task_Menu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Task_Menu;
            this.MaximizeBox = false;
            this.Name = "TaskView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách công việc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskView_FormClosing);
            this.Task_Menu.ResumeLayout(false);
            this.Task_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Task_Menu;
        private System.Windows.Forms.ToolStripMenuItem chươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_ReturnToTaskListView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Menu_ExitFromTaskView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ListView_Task;
        private System.Windows.Forms.ColumnHeader TaskId;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ToolStripMenuItem côngViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_AddNewTask;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Menu_EditTask;
        private System.Windows.Forms.ToolStripMenuItem Menu_FinishedTask;
        private System.Windows.Forms.ToolStripMenuItem Menu_DeleteTask;
    }
}