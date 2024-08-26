using Quản_Lý_Thư_Viện_Sách.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thư_Viện_Sách.Presentation.Admin
{
    public partial class AddEditAccountForm : Form
    {
        public Account Account { get; private set; }

        public AddEditAccountForm()
        {
            InitializeComponent();
            Account = new Account();
        }

        public AddEditAccountForm(Account account) : this()
        {
            Account = account;
            txtTenDangNhap.Text = account.TenDangNhap;
            txtDiaChi.Text = account.DiaChi;
            txtSoDienThoai.Text = account.SoDienThoai;
            txtMatKhau.Text = account.MatKhau;
            chkLaAdmin.Checked = account.LaAdmin;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Account.TenDangNhap = txtTenDangNhap.Text;
            Account.DiaChi = txtDiaChi.Text;
            Account.SoDienThoai = txtSoDienThoai.Text;
            Account.MatKhau = txtMatKhau.Text;
            Account.LaAdmin = chkLaAdmin.Checked;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
