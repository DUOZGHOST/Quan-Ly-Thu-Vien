using Quản_Lý_Thư_Viện_Sách.DAL;
using Quản_Lý_Thư_Viện_Sách.Models;
using Quản_Lý_Thư_Viện_Sách.Presentation.Auth;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quản_Lý_Thư_Viện_Sách.Presentation.User
{
    public partial class UserForm : Form
    {
        private Account _currentAccount;
        private BookRepository _bookRepository;

        public UserForm(Account account)
        {
            InitializeComponent();
            _currentAccount = account;
            _bookRepository = new BookRepository();
            LoadBooks();
        }

        private void LoadBooks()
        {
            lvBooks.Items.Clear();

            List<Book> books = GetBooksFromDatabase();

            foreach (var book in books)
            {
                var item = new ListViewItem(book.TieuDe);
                item.SubItems.Add(book.TacGia);
                item.SubItems.Add(book.DanhMuc.ToString());
                item.SubItems.Add(book.NhaXuatBan);
                item.SubItems.Add(book.NamXuatBan.ToString());
                item.SubItems.Add(book.SoLuongTonKho.ToString());
                item.SubItems.Add(book.TrangThai);
                lvBooks.Items.Add(item);
            }
        }

        private List<Book> GetBooksFromDatabase()
        {
            return _bookRepository.GetAllBooks().ToList();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            ShowForm(new UpdateAccountForm(_currentAccount));
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            ShowForm(new BorrowBookForm(_currentAccount));
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ShowForm(new ReturnBookForm(_currentAccount));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }

        private void ShowForm(Form form)
        {
            lvBooks.Visible = false;
            txtSearch.Visible = false;
            btnSearch.Visible = false;

            foreach (Control control in panelFunctionality.Controls.OfType<Form>().ToList())
            {
                panelFunctionality.Controls.Remove(control);
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelFunctionality.Controls.Add(form);
            form.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            lvBooks.Items.Clear();

            var filteredBooks = GetBooksFromDatabase()
                .Where(b => b.TieuDe.ToLower().Contains(keyword) || b.TacGia.ToLower().Contains(keyword));

            foreach (var book in filteredBooks)
            {
                var item = new ListViewItem(book.TieuDe);
                item.SubItems.Add(book.TacGia);
                item.SubItems.Add(book.DanhMuc.ToString());
                item.SubItems.Add(book.NhaXuatBan);
                item.SubItems.Add(book.NamXuatBan.ToString());
                item.SubItems.Add(book.SoLuongTonKho.ToString());
                item.SubItems.Add(book.TrangThai);
                lvBooks.Items.Add(item);
            }
        }

        private void btnBackToBooks_Click(object sender, EventArgs e)
        {
            LoadBooks();

            foreach (Control control in panelFunctionality.Controls.OfType<Form>().ToList())
            {
                panelFunctionality.Controls.Remove(control);
            }

            lvBooks.Visible = true;
            txtSearch.Visible = true;
            btnSearch.Visible = true;
        }
    }
}
