using Quản_Lý_Thư_Viện_Sách.BLL;
using Quản_Lý_Thư_Viện_Sách.Models;
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
    public partial class RegisterForm : Form
    {
        private AccountManager accountManager;

        public RegisterForm()
        {
            InitializeComponent();
            accountManager = new AccountManager();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().ToLower() == "admin")
            {
                MessageBox.Show("Username 'admin' không được phép. Vui lòng đặt tên đăng nhập khác.");
                return;
            }

            var newAccount = new Account
            {
                TenDangNhap = txtUsername.Text,
                MatKhau = txtPassword.Text,
                DiaChi = txtAddress.Text,
                SoDienThoai = txtPhoneNumber.Text,
            };

            try
            {
                accountManager.RegisterAccount(
                    txtFullName.Text,
                    txtAddress.Text,
                    txtPhoneNumber.Text,
                    txtUsername.Text,
                    txtPassword.Text
                );
                MessageBox.Show("Tài khoản đã được đăng ký thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
