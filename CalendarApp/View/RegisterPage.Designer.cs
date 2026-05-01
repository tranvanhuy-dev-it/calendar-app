namespace CalendarApp.View
{
    partial class RegisterPage
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
            this.fullNameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(255, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "ĐĂNG KÝ";
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.AcceptsReturn = true;
            this.fullNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTxt.Location = new System.Drawing.Point(47, 117);
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.Size = new System.Drawing.Size(265, 34);
            this.fullNameTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.AcceptsReturn = true;
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(389, 219);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(265, 34);
            this.passwordTxt.TabIndex = 3;
            // 
            // userNameTxt
            // 
            this.userNameTxt.AcceptsReturn = true;
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.Location = new System.Drawing.Point(47, 219);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(265, 34);
            this.userNameTxt.TabIndex = 3;
            // 
            // emailTxt
            // 
            this.emailTxt.AcceptsReturn = true;
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(389, 117);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(265, 34);
            this.emailTxt.TabIndex = 3;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.Lime;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(119, 278);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(460, 38);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Đăng ký ngay";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // loginLink
            // 
            this.loginLink.AutoSize = true;
            this.loginLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLink.Location = new System.Drawing.Point(212, 334);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(264, 22);
            this.loginLink.TabIndex = 5;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Đã có tài khoản? Đăng nhập";
            this.loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mật khẩu";
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(705, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.fullNameTxt);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(723, 431);
            this.MinimumSize = new System.Drawing.Size(723, 431);
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullNameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.LinkLabel loginLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}