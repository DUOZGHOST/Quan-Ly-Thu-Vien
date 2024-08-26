using Quản_Lý_Thư_Viện_Sách.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quản_Lý_Thư_Viện_Sách.Presentation.Admin
{
    public partial class ManageAccountsForm : Form
    {
        private AccountManager _accountManager;
        private const int PageSize = 10;
        private int _currentPage = 1;

        public ManageAccountsForm()
        {
            InitializeComponent();
            _accountManager = new AccountManager();
            LoadAccounts();
            InitializePagination();
        }

        private void LoadAccounts()
        {
            listViewAccounts.Items.Clear();
            var accounts = _accountManager.GetAllAccounts()
                .Skip((_currentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            foreach (var account in accounts)
            {
                var item = new ListViewItem(account.TenDangNhap);
                item.SubItems.Add(account.DiaChi);
                item.SubItems.Add(account.SoDienThoai);
                item.SubItems.Add(account.LaAdmin ? "Admin" : "User");
                item.SubItems.Add(account.IsActive ? "Active" : "Inactive");
                listViewAccounts.Items.Add(item);
            }
        }

        private void InitializePagination()
        {
            var totalAccounts = _accountManager.GetAllAccounts().Count();
            int totalPages = (int)Math.Ceiling((double)totalAccounts / PageSize);
            btnNextPage.Enabled = _currentPage < totalPages;
            btnPreviousPage.Enabled = _currentPage > 1;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            using (var addAccountForm = new AddEditAccountForm())
            {
                if (addAccountForm.ShowDialog() == DialogResult.OK)
                {
                    _accountManager.AddAccount(addAccountForm.Account);
                    LoadAccounts();
                    MessageBox.Show("Thêm tài khoản mới thành công!");
                }
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (listViewAccounts.SelectedItems.Count > 0)
            {
                string username = listViewAccounts.SelectedItems[0].Text;
                var account = _accountManager.GetAccountById(username);

                using (var editAccountForm = new AddEditAccountForm(account))
                {
                    if (editAccountForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            _accountManager.UpdateAccount(editAccountForm.Account);
                            LoadAccounts();
                            MessageBox.Show("Chỉnh sửa tài khoản thành công!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản để chỉnh sửa!");
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (listViewAccounts.SelectedItems.Count > 0)
            {
                string username = listViewAccounts.SelectedItems[0].Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        _accountManager.DeleteAccount(username);
                        LoadAccounts();
                        MessageBox.Show("Xóa tài khoản thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa!");
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _currentPage++;
            LoadAccounts();
            InitializePagination();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            _currentPage--;
            LoadAccounts();
            InitializePagination();
        }
    }
}
