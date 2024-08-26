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
    public partial class BorrowBookForm : Form
    {
        private Account _currentAccount;
        private BookManager _bookManager;

        public BorrowBookForm(Account account)
        {
            InitializeComponent();
            _currentAccount = account;
            _bookManager = new BookManager();
            LoadBooks();
        }

        private void LoadBooks()
        {
            var books = _bookManager.GetAllBooks();
            lstBooks.Items.Clear();

            foreach (var book in books)
            {
                lstBooks.Items.Add(new ListViewItem(new[]
                {
                    book.TieuDe,
                    book.TacGia,
                    book.NhaXuatBan,
                    book.NamXuatBan.Year.ToString(),
                    book.SoLuongTonKho.ToString()
                }));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();
            string searchCriteria = cboSearchCriteria.SelectedItem.ToString();
            var books = _bookManager.GetAllBooks();

            var filteredBooks = books.Where(b =>
                (searchCriteria == "Tên sách" && b.TieuDe.ToLower().Contains(searchTerm)) ||
                (searchCriteria == "Tác giả" && b.TacGia.ToLower().Contains(searchTerm)) ||
                (searchCriteria == "Nhà xuất bản" && b.NhaXuatBan.ToLower().Contains(searchTerm))
            ).ToList();

            lstBooks.Items.Clear();
            foreach (var book in filteredBooks)
            {
                lstBooks.Items.Add(new ListViewItem(new[]
                {
                    book.TieuDe,
                    book.TacGia,
                    book.NhaXuatBan,
                    book.NamXuatBan.Year.ToString(),
                    book.SoLuongTonKho.ToString()
                }));
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItems.Count > 0)
            {
                string tieuDe = lstBooks.SelectedItems[0].SubItems[0].Text;
                string tenDangNhap = _currentAccount.TenDangNhap;

                var book = _bookManager.GetBookById(tieuDe);
                if (book != null && book.SoLuongTonKho > 0)
                {
                    Loan loan = new Loan
                    {
                        TenDangNhap = tenDangNhap,
                        TieuDe = book.TieuDe,
                        NgayMuon = DateTime.Now,
                        NgayTra = dtpReturnDate.Value.Date,
                        TrangThai = "Đang mượn",
                    };

                    LoanManager loanManager = new LoanManager();
                    loanManager.AddLoan(loan);

                    book.SoLuongTonKho--;
                    _bookManager.UpdateBook(book);

                    MessageBox.Show("Đã mượn sách thành công!");
                }
                else
                {
                    MessageBox.Show("Sách không còn trong kho hoặc không tồn tại.");
                }
                MessageBox.Show("Đã mượn sách thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách để mượn.");
            }
        }
    }
}
