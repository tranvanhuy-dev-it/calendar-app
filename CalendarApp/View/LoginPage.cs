using CalendarApp.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp.View
{
    public partial class LoginPage : Form
    {
        private IUserService _userService;
        public LoginPage(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            passwordTxt.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = Program.ServiceProvider.GetRequiredService<RegisterPage>();
            registerForm.Show(); this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = userNameTxt.Text;
            string password = passwordTxt.Text;
            
            try
            {
                int loggedInUser = _userService.Login(username, password);
                var calenderForm = Program.ServiceProvider.GetRequiredService<CalendarPage>();
                calenderForm.InitData(loggedInUser);
                calenderForm.Show(); this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = !showPassChk.Checked;
        }
    }
}
