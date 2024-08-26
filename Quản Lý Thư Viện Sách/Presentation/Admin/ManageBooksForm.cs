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
    public partial class ManageBooksForm : Form
    {
        private BookManager _bookManager;
        private const int PageSize = 10;
        private int _currentPage = 1;

        public ManageBooksForm()
        {
            InitializeComponent();
            _bookManager = new BookManager();
            LoadBooks();
            InitializePagination();
        }

        private void LoadBooks()
        {
            listViewBooks.Items.Clear();
            var books = _bookManager.GetAllBooks()
                            .Skip((_currentPage - 1) * PageSize)
                            .Take(PageSize)
                            .ToList();

            foreach (var book in books)
            {
                var listViewItem = new ListViewItem(book.TieuDe);
                listViewItem.SubItems.Add(book.TacGia);
                listViewItem.SubItems.Add(book.DanhMuc);
                listViewItem.SubItems.Add(book.NhaXuatBan);
                listViewItem.SubItems.Add(book.NamXuatBan.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(book.SoLuongTonKho.ToString());
                listViewItem.SubItems.Add(book.TrangThai);
                listViewBooks.Items.Add(listViewItem);
            }
        }

        private void InitializePagination()
        {
            var totalBooks = _bookManager.GetAllBooks().Count();
            int totalPages = (int)Math.Ceiling((double)totalBooks / PageSize);
            btnNextPage.Enabled = _currentPage < totalPages;
            btnPreviousPage.Enabled = _currentPage > 1;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var addEditBookForm = new AddEditBookForm();
            if (addEditBookForm.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
                MessageBox.Show("Thêm sách mới thành công!");
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count > 0)
            {
                var selectedItem = listViewBooks.SelectedItems[0];
                string bookTieuDe = selectedItem.Text;
                var book = _bookManager.GetBookById(bookTieuDe);

                var addEditBookForm = new AddEditBookForm(book);
                if (addEditBookForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks();
                    MessageBox.Show("Chỉnh sửa sách thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để sửa!");
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var selectedItem = listViewBooks.SelectedItems[0];
                    string bookTieuDe = selectedItem.Text;
                    _bookManager.DeleteBook(bookTieuDe);
                    LoadBooks();
                    MessageBox.Show("Xóa sách thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để xóa!");
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _currentPage++;
            LoadBooks();
            InitializePagination();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            _currentPage--;
            LoadBooks();
            InitializePagination();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text.ToLower();
            var books = _bookManager.GetAllBooks()
                .Where(b => b.TieuDe.ToLower().Contains(searchText) || b.TacGia.ToLower().Contains(searchText))
                .Skip((_currentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            listViewBooks.Items.Clear();
            foreach (var book in books)
            {
                var listViewItem = new ListViewItem(book.TieuDe);
                listViewItem.SubItems.Add(book.TacGia);
                listViewItem.SubItems.Add(book.DanhMuc);
                listViewItem.SubItems.Add(book.NhaXuatBan);
                listViewItem.SubItems.Add(book.NamXuatBan.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(book.SoLuongTonKho.ToString());
                listViewItem.SubItems.Add(book.TrangThai);
                listViewBooks.Items.Add(listViewItem);
            }
        }
    }
}
