using Quản_Lý_Thư_Viện_Sách.BLL;
using Quản_Lý_Thư_Viện_Sách.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thư_Viện_Sách.Presentation.User
{
    public partial class ReturnBookForm : Form
    {
        private LoanManager _loanManager;
        private BookManager _bookManager;
        private Account _currentAccount;

        public ReturnBookForm(Account account)
        {
            InitializeComponent();
            _loanManager = new LoanManager();
            _bookManager = new BookManager();
            _currentAccount = account;
            LoadLoans(account.TenDangNhap);
        }

        private void LoadLoans(string accountUsername)
        {
            var loans = _loanManager.GetAllLoansForAccount(accountUsername).ToList();
            var filteredLoans = loans.Where(l =>
                l.NgayTra == null || l.NgayTra > DateTime.Now
            ).ToList();

            lstLoans.Items.Clear();
            foreach (var loan in loans)
            {
                var item = new ListViewItem(new[]
                {
                    loan.Id.ToString(),
                    loan.TieuDe,
                    loan.TenDangNhap,
                    loan.NgayMuon.ToString("dd/MM/yyyy"),
                    loan.NgayTra.HasValue ? loan.NgayTra.Value.ToString("dd/MM/yyyy") : "Chưa trả"
                });
                lstLoans.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();
            string searchCriteria = cboSearchCriteria.SelectedItem.ToString();
            var loans = _loanManager.GetAllLoans();

            var filteredLoans = loans.Where(l =>
                (searchCriteria == "Tên sách" && l.Book.TieuDe.ToLower().Contains(searchTerm)) ||
                (searchCriteria == "Tác giả" && l.Book.TacGia.ToLower().Contains(searchTerm)) ||
                (searchCriteria == "Tên tài khoản" && l.Account.TenDangNhap.ToLower().Contains(searchTerm))
            ).ToList();

            lstLoans.Items.Clear();
            foreach (var loan in filteredLoans)
            {
                lstLoans.Items.Add(new ListViewItem(new[]
                {
                    loan.Id.ToString(),
                    loan.Book.TieuDe,
                    loan.Account.TenDangNhap,
                    loan.NgayMuon.ToString("dd/MM/yyyy")
                }));
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lstLoans.SelectedItems.Count > 0)
            {
                int loanId = int.Parse(lstLoans.SelectedItems[0].SubItems[0].Text);
                var loan = _loanManager.GetLoanById(loanId);

                if (loan != null)
                {
                    loan.NgayTra = DateTime.Now;
                    loan.TrangThai = "Đã trả";

                    _loanManager.UpdateLoan(loan);

                    var book = _bookManager.GetBookById(loan.Book.TieuDe);
                    if (book != null)
                    {
                        book.SoLuongTonKho++;
                        _bookManager.UpdateBook(book);
                    }

                    MessageBox.Show("Đã trả sách thành công!");
                    LoadLoans(_currentAccount.TenDangNhap);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khoản mượn.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khoản mượn để trả.");
            }
        }
    }
}
