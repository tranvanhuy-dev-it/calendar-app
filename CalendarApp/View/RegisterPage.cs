using CalendarApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace CalendarApp.View
{
    public partial class RegisterPage : Form
    {
        private IUserService _userService;
        public RegisterPage(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadLoginPage();
            this.Close();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = userNameTxt.Text;
            string password = passwordTxt.Text;
            string email = emailTxt.Text;
            string fullName = fullNameTxt.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            try
            {
                var _ = new MailAddress(email);
            }
            catch
            {
                MessageBox.Show("Email không đúng định dạng");
                return;
            }

            try
            {
                _userService.Register(new DTO.AddUserDTO
                {
                    username = username,
                    password = password,
                    email = email,
                    full_name = fullName
                });
                MessageBox.Show("Đăng ký thành công");
                LoadLoginPage();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadLoginPage()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is LoginPage)
                {
                    form.Show();
                    break;
                }
            }
        }
    }
}
