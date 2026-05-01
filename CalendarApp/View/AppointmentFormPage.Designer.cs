namespace CalendarApp.View
{
    partial class AppointmentFormPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.dateTxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(204, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "THÊM LỊCH HẸN";
            // 
            // start
            // 
            this.start.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.start.Location = new System.Drawing.Point(41, 104);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(265, 34);
            this.start.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiêu đề";
            // 
            // title
            // 
            this.title.AcceptsReturn = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(41, 202);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(265, 34);
            this.title.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa điểm";
            // 
            // location
            // 
            this.location.AcceptsReturn = true;
            this.location.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.Location = new System.Drawing.Point(372, 202);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(265, 34);
            this.location.TabIndex = 9;
            // 
            // end
            // 
            this.end.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.end.Location = new System.Drawing.Point(372, 104);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(265, 34);
            this.end.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kết thúc";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Lime;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(541, 268);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(96, 38);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dateTxt
            // 
            this.dateTxt.AutoSize = true;
            this.dateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTxt.Location = new System.Drawing.Point(37, 268);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(47, 20);
            this.dateTxt.TabIndex = 12;
            this.dateTxt.Text = "Ngày";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(372, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Hũy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AppointmentFormPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(676, 330);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.title);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label2);
            this.Name = "AppointmentFormPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddAppointmentPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label dateTxt;
        private System.Windows.Forms.Button button1;
    }
}