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

namespace Quản_Lý_Thư_Viện_Sách.Presentation.Admin
{
    public partial class ManageLoansForm : Form
    {
        private LoanManager _loanManager;
        private const int PageSize = 10;
        private int _currentPage = 1;

        public ManageLoansForm()
        {
            InitializeComponent();
            _loanManager = new LoanManager();
            LoadLoans();
            InitializePagination();
        }

        private void LoadLoans()
        {
            listViewLoans.Items.Clear();
            var loans = _loanManager.GetAllLoans()
                .Skip((_currentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            foreach (var loan in loans)
            {
                var item = new ListViewItem(loan.Id.ToString());
                item.SubItems.Add(loan.TenDangNhap.ToString());
                item.SubItems.Add(loan.TieuDe.ToString());
                item.SubItems.Add(loan.NgayMuon.ToShortDateString());
                item.SubItems.Add(loan.NgayTra?.ToShortDateString() ?? "Chưa trả");
                item.SubItems.Add(loan.TrangThai);
                listViewLoans.Items.Add(item);
            }
        }

        private void InitializePagination()
        {
            var totalLoans = _loanManager.GetAllLoans().Count();
            int totalPages = (int)Math.Ceiling((double)totalLoans / PageSize);
            btnNextPage.Enabled = _currentPage < totalPages;
            btnPreviousPage.Enabled = _currentPage > 1;
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            using (var addLoanForm = new AddEditLoanForm())
            {
                if (addLoanForm.ShowDialog() == DialogResult.OK)
                {
                    LoadLoans();
                    MessageBox.Show("Thêm khoản mượn thành công!");
                }
            }
        }

        private void btnEditLoan_Click(object sender, EventArgs e)
        {
            if (listViewLoans.SelectedItems.Count > 0)
            {
                int loanId = int.Parse(listViewLoans.SelectedItems[0].Text);
                var loan = _loanManager.GetLoanById(loanId);

                using (var editLoanForm = new AddEditLoanForm(loan))
                {
                    if (editLoanForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadLoans();
                        MessageBox.Show("Chỉnh sửa khoản mượn thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khoản mượn để chỉnh sửa!");
            }
        }

        private void btnDeleteLoan_Click(object sender, EventArgs e)
        {
            if (listViewLoans.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khoản mượn này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int loanId = int.Parse(listViewLoans.SelectedItems[0].Text);
                    _loanManager.DeleteLoan(loanId);
                    LoadLoans();
                    MessageBox.Show("Xóa khoản mượn thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khoản vay để xóa!");
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _currentPage++;
            LoadLoans();
            InitializePagination();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            _currentPage--;
            LoadLoans();
            InitializePagination();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text.ToLower();
            var loans = _loanManager.GetAllLoans()
                .Where(l => l.TrangThai.ToLower().Contains(searchText))
                .Skip((_currentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            listViewLoans.Items.Clear();
            foreach (var loan in loans)
            {
                var item = new ListViewItem(loan.Id.ToString());
                item.SubItems.Add(loan.TenDangNhap.ToString());
                item.SubItems.Add(loan.TieuDe.ToString());
                item.SubItems.Add(loan.NgayMuon.ToShortDateString());
                item.SubItems.Add(loan.NgayTra?.ToShortDateString() ?? "Chưa trả");
                item.SubItems.Add(loan.TrangThai);
                listViewLoans.Items.Add(item);
            }
        }
    }
}
