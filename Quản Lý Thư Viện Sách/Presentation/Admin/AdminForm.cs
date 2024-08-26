using Quản_Lý_Thư_Viện_Sách.DAL;
using Quản_Lý_Thư_Viện_Sách.Models;
using Quản_Lý_Thư_Viện_Sách.Presentation.Auth;
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
    public partial class AdminForm : Form
    {
        private BookRepository _bookRepository;

        public AdminForm()
        {
            InitializeComponent();
            _bookRepository = new BookRepository();
            LoadBooks();
            InitializeSearchComboBox();
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
                item.SubItems.Add(book.NamXuatBan.Year.ToString());
                item.SubItems.Add(book.SoLuongTonKho.ToString());
                item.SubItems.Add(book.TrangThai);
                lvBooks.Items.Add(item);
            }
        }

        private List<Book> GetBooksFromDatabase()
        {
            return _bookRepository.GetAllBooks().ToList();
        }

        private void InitializeSearchComboBox()
        {
            cbSearchCriteria.Items.Add("Tiêu Đề");
            cbSearchCriteria.Items.Add("Tác Giả");
            cbSearchCriteria.Items.Add("Danh Mục");
            cbSearchCriteria.Items.Add("Nhà Xuất Bản");
            cbSearchCriteria.SelectedIndex = 0;
        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            HideSearchControls();
            ShowForm(new ManageAccountsForm());
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            HideSearchControls();
            ShowForm(new ManageBooksForm());
        }

        private void btnManageLoans_Click(object sender, EventArgs e)
        {
            HideSearchControls();
            ShowForm(new ManageLoansForm());
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            HideSearchControls();
            ShowForm(new ReportForm());
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

            var filteredBooks = GetBooksFromDatabase();

            switch (cbSearchCriteria.SelectedItem.ToString())
            {
                case "Tiêu Đề":
                    filteredBooks = filteredBooks.Where(b => b.TieuDe.ToLower().Contains(keyword)).ToList();
                    break;
                case "Tác Giả":
                    filteredBooks = filteredBooks.Where(b => b.TacGia.ToLower().Contains(keyword)).ToList();
                    break;
                case "Danh Mục":
                    filteredBooks = filteredBooks.Where(b => b.DanhMuc.ToString().ToLower().Contains(keyword)).ToList();
                    break;
                case "Nhà Xuất Bản":
                    filteredBooks = filteredBooks.Where(b => b.NhaXuatBan.ToLower().Contains(keyword)).ToList();
                    break;
            }

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
            ShowSearchControls();
        }

        private void HideSearchControls()
        {
            txtSearch.Visible = false;
            btnSearch.Visible = false;
            cbSearchCriteria.Visible = false;
        }

        private void ShowSearchControls()
        {
            txtSearch.Visible = true;
            btnSearch.Visible = true;
            cbSearchCriteria.Visible = true;
        }
    }
}
