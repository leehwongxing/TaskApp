namespace WF.Views
{
    partial class TaskListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskListView));
            this.TaskList_Menu = new System.Windows.Forms.MenuStrip();
            this.chươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_ExitFromTaskListView = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_GoToTaskView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_CreateNewTaskList = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_EditTaskList = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTaskList = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.ListView_TaskList = new System.Windows.Forms.ListView();
            this.TaskListId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskList_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskList_Menu
            // 
            this.TaskList_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chươngTrìnhToolStripMenuItem,
            this.danhMụcToolStripMenuItem});
            this.TaskList_Menu.Location = new System.Drawing.Point(0, 0);
            this.TaskList_Menu.Name = "TaskList_Menu";
            this.TaskList_Menu.Size = new System.Drawing.Size(264, 24);
            this.TaskList_Menu.TabIndex = 1;
            this.TaskList_Menu.Text = "menuStrip1";
            // 
            // chươngTrìnhToolStripMenuItem
            // 
            this.chươngTrìnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_SignOut,
            this.toolStripSeparator1,
            this.Menu_ExitFromTaskListView});
            this.chươngTrìnhToolStripMenuItem.Name = "chươngTrìnhToolStripMenuItem";
            this.chươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.chươngTrìnhToolStripMenuItem.Text = "Chương trình";
            // 
            // Menu_SignOut
            // 
            this.Menu_SignOut.Name = "Menu_SignOut";
            this.Menu_SignOut.Size = new System.Drawing.Size(127, 22);
            this.Menu_SignOut.Text = "Đăng xuất";
            this.Menu_SignOut.Click += new System.EventHandler(this.Menu_SignOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // Menu_ExitFromTaskListView
            // 
            this.Menu_ExitFromTaskListView.Name = "Menu_ExitFromTaskListView";
            this.Menu_ExitFromTaskListView.Size = new System.Drawing.Size(127, 22);
            this.Menu_ExitFromTaskListView.Text = "Thoát";
            this.Menu_ExitFromTaskListView.Click += new System.EventHandler(this.Menu_ExitFromTaskListView_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_GoToTaskView,
            this.toolStripSeparator2,
            this.Menu_CreateNewTaskList,
            this.Menu_EditTaskList,
            this.DeleteTaskList});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // Menu_GoToTaskView
            // 
            this.Menu_GoToTaskView.Name = "Menu_GoToTaskView";
            this.Menu_GoToTaskView.Size = new System.Drawing.Size(183, 22);
            this.Menu_GoToTaskView.Text = "Danh sách công việc";
            this.Menu_GoToTaskView.Click += new System.EventHandler(this.Menu_GoToTaskView_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // Menu_CreateNewTaskList
            // 
            this.Menu_CreateNewTaskList.Name = "Menu_CreateNewTaskList";
            this.Menu_CreateNewTaskList.Size = new System.Drawing.Size(183, 22);
            this.Menu_CreateNewTaskList.Text = "Tạo danh mục mới";
            this.Menu_CreateNewTaskList.Click += new System.EventHandler(this.Menu_CreateNewTaskList_Click);
            // 
            // Menu_EditTaskList
            // 
            this.Menu_EditTaskList.Name = "Menu_EditTaskList";
            this.Menu_EditTaskList.Size = new System.Drawing.Size(183, 22);
            this.Menu_EditTaskList.Text = "Chỉnh sửa";
            this.Menu_EditTaskList.Click += new System.EventHandler(this.Menu_EditTaskList_Click);
            // 
            // DeleteTaskList
            // 
            this.DeleteTaskList.Name = "DeleteTaskList";
            this.DeleteTaskList.Size = new System.Drawing.Size(183, 22);
            this.DeleteTaskList.Text = "Xóa";
            this.DeleteTaskList.Click += new System.EventHandler(this.DeleteTaskList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Danh mục công việc";
            // 
            // ListView_TaskList
            // 
            this.ListView_TaskList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView_TaskList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TaskListId,
            this.Title});
            this.ListView_TaskList.FullRowSelect = true;
            this.ListView_TaskList.GridLines = true;
            this.ListView_TaskList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView_TaskList.Location = new System.Drawing.Point(12, 93);
            this.ListView_TaskList.Name = "ListView_TaskList";
            this.ListView_TaskList.Size = new System.Drawing.Size(240, 356);
            this.ListView_TaskList.TabIndex = 12;
            this.ListView_TaskList.UseCompatibleStateImageBehavior = false;
            this.ListView_TaskList.View = System.Windows.Forms.View.Details;
            this.ListView_TaskList.DoubleClick += new System.EventHandler(this.ListView_TaskList_DoubleClick);
            // 
            // TaskListId
            // 
            this.TaskListId.Width = 0;
            // 
            // Title
            // 
            this.Title.Text = "Danh mục";
            this.Title.Width = 240;
            // 
            // TaskListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 461);
            this.Controls.Add(this.ListView_TaskList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TaskList_Menu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TaskList_Menu;
            this.MaximizeBox = false;
            this.Name = "TaskListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục công việc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskListView_FormClosing);
            this.TaskList_Menu.ResumeLayout(false);
            this.TaskList_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip TaskList_Menu;
        private System.Windows.Forms.ToolStripMenuItem chươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_SignOut;
        private System.Windows.Forms.ToolStripMenuItem Menu_ExitFromTaskListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ListView_TaskList;
        private System.Windows.Forms.ColumnHeader TaskListId;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_GoToTaskView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Menu_EditTaskList;
        private System.Windows.Forms.ToolStripMenuItem DeleteTaskList;
        private System.Windows.Forms.ToolStripMenuItem Menu_CreateNewTaskList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}