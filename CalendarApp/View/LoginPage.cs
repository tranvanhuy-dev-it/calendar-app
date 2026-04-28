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

namespace CalendarApp.View
{
    public partial class LoginPage : Form
    {
        private UserService _userService;
        public LoginPage()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage registerForm = new RegisterPage();
            registerForm.Show(); this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = userNameTxt.Text;
            string password = passwordTxt.Text;
            
            try
            {
                int loggedInUser = _userService.Login(username, password);
                CalendarPage calendarForm = new CalendarPage(loggedInUser);
                calendarForm.Show(); this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
