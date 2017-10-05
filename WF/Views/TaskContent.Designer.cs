namespace WF.Views
{
    partial class TaskContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskContent));
            this.Tx_Title = new System.Windows.Forms.TextBox();
            this.Tx_Content = new System.Windows.Forms.TextBox();
            this.Tp_Date = new System.Windows.Forms.DateTimePicker();
            this.Tp_Time = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_DueDate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tx_Title
            // 
            this.Tx_Title.Location = new System.Drawing.Point(10, 105);
            this.Tx_Title.Name = "Tx_Title";
            this.Tx_Title.Size = new System.Drawing.Size(239, 23);
            this.Tx_Title.TabIndex = 0;
            // 
            // Tx_Content
            // 
            this.Tx_Content.Location = new System.Drawing.Point(12, 216);
            this.Tx_Content.Multiline = true;
            this.Tx_Content.Name = "Tx_Content";
            this.Tx_Content.Size = new System.Drawing.Size(239, 136);
            this.Tx_Content.TabIndex = 1;
            // 
            // Tp_Date
            // 
            this.Tp_Date.CustomFormat = "dd/MM/yyyy";
            this.Tp_Date.Enabled = false;
            this.Tp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Tp_Date.Location = new System.Drawing.Point(12, 164);
            this.Tp_Date.Name = "Tp_Date";
            this.Tp_Date.Size = new System.Drawing.Size(132, 23);
            this.Tp_Date.TabIndex = 2;
            // 
            // Tp_Time
            // 
            this.Tp_Time.Enabled = false;
            this.Tp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Tp_Time.Location = new System.Drawing.Point(148, 164);
            this.Tp_Time.Name = "Tp_Time";
            this.Tp_Time.ShowUpDown = true;
            this.Tp_Time.Size = new System.Drawing.Size(101, 23);
            this.Tp_Time.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên công việc";
            // 
            // chk_DueDate
            // 
            this.chk_DueDate.AutoSize = true;
            this.chk_DueDate.Location = new System.Drawing.Point(12, 139);
            this.chk_DueDate.Name = "chk_DueDate";
            this.chk_DueDate.Size = new System.Drawing.Size(100, 19);
            this.chk_DueDate.TabIndex = 5;
            this.chk_DueDate.Text = "Ngày đến hạn";
            this.chk_DueDate.UseVisualStyleBackColor = true;
            this.chk_DueDate.CheckedChanged += new System.EventHandler(this.chk_DueDate_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nội dung";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(191, 376);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(60, 23);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Thông tin công việc";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(125, 376);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(60, 23);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "Đóng";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // TaskContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chk_DueDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tp_Time);
            this.Controls.Add(this.Tp_Date);
            this.Controls.Add(this.Tx_Content);
            this.Controls.Add(this.Tx_Title);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nội dung công việc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskContent_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tx_Title;
        private System.Windows.Forms.TextBox Tx_Content;
        private System.Windows.Forms.DateTimePicker Tp_Date;
        private System.Windows.Forms.DateTimePicker Tp_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_DueDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Close;
    }
}