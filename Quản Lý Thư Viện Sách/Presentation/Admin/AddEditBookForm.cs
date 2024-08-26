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

namespace Quản_Lý_Thư_Viện_Sách.Presentation.Admin
{
    public partial class AddEditBookForm : Form
    {
        private Book _book;

        public AddEditBookForm()
        {
            InitializeComponent();
            InitializeComboBox();
            ClearInputs();
        }

        public AddEditBookForm(Book book) : this()
        {
            _book = book;
            txtTieuDe.Text = _book.TieuDe;
            txtTacGia.Text = _book.TacGia;
            txtDanhMuc.Text = _book.DanhMuc;
            txtNhaXuatBan.Text = _book.NhaXuatBan;
            dtpNamXuatBan.Value = _book.NamXuatBan;
            txtSoLuongTonKho.Text = _book.SoLuongTonKho.HasValue ? _book.SoLuongTonKho.Value.ToString() : string.Empty;
            cboTrangThai.SelectedItem = _book.TrangThai;
        }

        private void InitializeComboBox()
        {
            cboTrangThai.Items.Add("Mới");
            cboTrangThai.Items.Add("Cũ");
            cboTrangThai.Items.Add("Like new");
            cboTrangThai.Items.Add("Sách đã đọc");
            cboTrangThai.SelectedIndex = 0;
        }

        private void ClearInputs()
        {
            txtTieuDe.Clear();
            txtTacGia.Clear();
            txtDanhMuc.Clear();
            txtNhaXuatBan.Clear();
            txtSoLuongTonKho.Clear();
            dtpNamXuatBan.Value = DateTime.Now;
            cboTrangThai.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (_book == null)
                {
                    _book = new Book();
                }

                _book.TieuDe = txtTieuDe.Text;
                _book.TacGia = txtTacGia.Text;
                _book.DanhMuc = txtDanhMuc.Text;
                _book.NhaXuatBan = txtNhaXuatBan.Text;
                _book.NamXuatBan = dtpNamXuatBan.Value;
                _book.SoLuongTonKho = string.IsNullOrEmpty(txtSoLuongTonKho.Text) ? (int?)null : int.Parse(txtSoLuongTonKho.Text);
                _book.TrangThai = cboTrangThai.SelectedItem.ToString();

                var bookManager = new BookManager();
                if (bookManager.GetBookById(_book.TieuDe) != null)
                {
                    bookManager.UpdateBook(_book);
                }
                else
                {
                    bookManager.AddBook(_book);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtTieuDe.Text) ||
                string.IsNullOrEmpty(txtTacGia.Text) ||
                string.IsNullOrEmpty(txtDanhMuc.Text) ||
                string.IsNullOrEmpty(txtNhaXuatBan.Text) ||
                !int.TryParse(txtSoLuongTonKho.Text, out int soLuong) ||
                soLuong < 0 || 
                cboTrangThai.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
