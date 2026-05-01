namespace CalendarApp.View
{
    partial class CalendarPage
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
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.today = new System.Windows.Forms.Label();
            this.jj = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.week = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRmd = new System.Windows.Forms.DataGridView();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DelRmdBtn = new System.Windows.Forms.Button();
            this.delApmBtn = new System.Windows.Forms.Button();
            this.updateRmdBtn = new System.Windows.Forms.Button();
            this.updateApmBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRmd)).BeginInit();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.Gainsboro;
            this.calendar.Location = new System.Drawing.Point(34, 99);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(385, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "QUẢN LÝ LỊCH HẸN";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Lime;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(640, 323);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(182, 37);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Thêm cuộc hẹn";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách cuộc hẹn trong ngày";
            // 
            // today
            // 
            this.today.AutoSize = true;
            this.today.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.today.Location = new System.Drawing.Point(30, 405);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(88, 22);
            this.today.TabIndex = 6;
            this.today.Text = "Hôm nay";
            // 
            // jj
            // 
            this.jj.AutoSize = true;
            this.jj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jj.Location = new System.Drawing.Point(83, 64);
            this.jj.Name = "jj";
            this.jj.Size = new System.Drawing.Size(103, 22);
            this.jj.TabIndex = 6;
            this.jj.Text = "Lịch tháng";
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.Location = new System.Drawing.Point(30, 485);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(105, 22);
            this.month.TabIndex = 6;
            this.month.Text = "Tháng này";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(289, 99);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(737, 207);
            this.dgv.TabIndex = 7;
            // 
            // week
            // 
            this.week.AutoSize = true;
            this.week.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.week.Location = new System.Drawing.Point(30, 445);
            this.week.Name = "week";
            this.week.Size = new System.Drawing.Size(94, 22);
            this.week.TabIndex = 6;
            this.week.Text = "Tuần này";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(625, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lời nhắc";
            // 
            // dgvRmd
            // 
            this.dgvRmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRmd.Location = new System.Drawing.Point(289, 405);
            this.dgvRmd.Name = "dgvRmd";
            this.dgvRmd.RowHeadersWidth = 51;
            this.dgvRmd.RowTemplate.Height = 24;
            this.dgvRmd.Size = new System.Drawing.Size(737, 207);
            this.dgvRmd.TabIndex = 8;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Crimson;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(34, 575);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(206, 37);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Đăng xuất";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(641, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm lời nhắc";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DelRmdBtn
            // 
            this.DelRmdBtn.BackColor = System.Drawing.Color.Red;
            this.DelRmdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelRmdBtn.Location = new System.Drawing.Point(930, 630);
            this.DelRmdBtn.Name = "DelRmdBtn";
            this.DelRmdBtn.Size = new System.Drawing.Size(96, 37);
            this.DelRmdBtn.TabIndex = 10;
            this.DelRmdBtn.Text = "Xóa";
            this.DelRmdBtn.UseVisualStyleBackColor = false;
            this.DelRmdBtn.Click += new System.EventHandler(this.DelRmdBtn_Click);
            // 
            // delApmBtn
            // 
            this.delApmBtn.BackColor = System.Drawing.Color.Red;
            this.delApmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delApmBtn.Location = new System.Drawing.Point(930, 323);
            this.delApmBtn.Name = "delApmBtn";
            this.delApmBtn.Size = new System.Drawing.Size(96, 37);
            this.delApmBtn.TabIndex = 11;
            this.delApmBtn.Text = "Xóa";
            this.delApmBtn.UseVisualStyleBackColor = false;
            this.delApmBtn.Click += new System.EventHandler(this.delApmBtn_Click);
            // 
            // updateRmdBtn
            // 
            this.updateRmdBtn.BackColor = System.Drawing.Color.Yellow;
            this.updateRmdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRmdBtn.Location = new System.Drawing.Point(829, 630);
            this.updateRmdBtn.Name = "updateRmdBtn";
            this.updateRmdBtn.Size = new System.Drawing.Size(96, 37);
            this.updateRmdBtn.TabIndex = 12;
            this.updateRmdBtn.Text = "Sửa";
            this.updateRmdBtn.UseVisualStyleBackColor = false;
            this.updateRmdBtn.Click += new System.EventHandler(this.updateRmdBtn_Click);
            // 
            // updateApmBtn
            // 
            this.updateApmBtn.BackColor = System.Drawing.Color.Yellow;
            this.updateApmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateApmBtn.Location = new System.Drawing.Point(829, 323);
            this.updateApmBtn.Name = "updateApmBtn";
            this.updateApmBtn.Size = new System.Drawing.Size(96, 37);
            this.updateApmBtn.TabIndex = 13;
            this.updateApmBtn.Text = "Sửa";
            this.updateApmBtn.UseVisualStyleBackColor = false;
            this.updateApmBtn.Click += new System.EventHandler(this.updateApmBtn_Click);
            // 
            // CalendarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1051, 688);
            this.Controls.Add(this.updateApmBtn);
            this.Controls.Add(this.updateRmdBtn);
            this.Controls.Add(this.delApmBtn);
            this.Controls.Add(this.DelRmdBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRmd);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.month);
            this.Controls.Add(this.jj);
            this.Controls.Add(this.week);
            this.Controls.Add(this.today);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calendar);
            this.MinimumSize = new System.Drawing.Size(723, 431);
            this.Name = "CalendarPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalendarPage";
            this.VisibleChanged += new System.EventHandler(this.CalendarPage_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRmd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label today;
        private System.Windows.Forms.Label jj;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label week;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRmd;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DelRmdBtn;
        private System.Windows.Forms.Button delApmBtn;
        private System.Windows.Forms.Button updateRmdBtn;
        private System.Windows.Forms.Button updateApmBtn;
    }
}