using Quản_Lý_Thư_Viện_Sách.Presentation.Admin;
using Quản_Lý_Thư_Viện_Sách.Presentation.User;
using Quản_Lý_Thư_Viện_Sách.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thư_Viện_Sách.Presentation.Auth
{
    public partial class LoginForm : Form
    {
        private AccountManager accountManager;
        public bool LaAdmin { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            accountManager = new AccountManager();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var account = accountManager.ValidateUser(username, password);
            if (account != null)
            {
                LaAdmin = account.LaAdmin;

                if (LaAdmin && !radioAdmin.Checked)
                {
                    MessageBox.Show("Tài khoản admin yêu cầu chọn 'Thủ thư' để đăng nhập!");
                    return;
                }

                else if (!LaAdmin && !radioUser.Checked)
                {
                    MessageBox.Show("Tài khoản người dùng yêu cầu chọn 'Người dùng' để đăng nhập!");
                    return;
                }

                if (LaAdmin)
                {
                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.ShowDialog();
                }
                else
                {
                    UserForm userForm = new UserForm(account);
                    this.Hide();
                    userForm.ShowDialog();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai username hoặc password.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}
