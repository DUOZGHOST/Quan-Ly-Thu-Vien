using Quản_Lý_Thư_Viện_Sách.BLL;
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

namespace Quản_Lý_Thư_Viện_Sách.Presentation.User
{
    public partial class UpdateAccountForm : Form
    {
        private Account _currentAccount;
        private AccountManager _accountManager;

        public UpdateAccountForm(Account account)
        {
            InitializeComponent();
            _currentAccount = account;
            _accountManager = new AccountManager();
            LoadAccountData();
        }

        private void LoadAccountData()
        {
            txtDiaChi.Text = _currentAccount.DiaChi;
            txtSoDienThoai.Text = _currentAccount.SoDienThoai;
            txtTenDangNhap.Text = _currentAccount.TenDangNhap;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _currentAccount.DiaChi = txtDiaChi.Text;
            _currentAccount.SoDienThoai = txtSoDienThoai.Text;
            string newPassword = txtMatKhau.Text;

            try
            {
                _accountManager.UpdateAccount(_currentAccount, newPassword);
                MessageBox.Show("Cập nhật tài khoản thành công.");
                LoadAccountData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy không? Thông tin cũ sẽ được hiển thị lại.", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                LoadAccountData();
            }
        }
    }
}
