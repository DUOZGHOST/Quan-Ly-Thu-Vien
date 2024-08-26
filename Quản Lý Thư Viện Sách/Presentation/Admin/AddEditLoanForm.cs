using Quản_Lý_Thư_Viện_Sách.DAL;
using Quản_Lý_Thư_Viện_Sách.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thư_Viện_Sách.Presentation.Admin
{
    public partial class AddEditLoanForm : Form
    {
        public Loan Loan { get; private set; }

        public AddEditLoanForm()
        {
            InitializeComponent();
            LoadLoanStatusOptions();
        }

        public AddEditLoanForm(Loan loan) : this()
        {
            if (loan == null)
            {
                Loan = new Loan
                {
                    TrangThai = "Đang Mượn"
                };
            }
            else
            {
                Loan = loan;
                LoadLoanData();
            }
        }

        private void LoadLoanData()
        {
            if (Loan != null)
            {
                txtTenDangNhap.Text = Loan.TenDangNhap;
                txtTieuDeSach.Text = Loan.TieuDe;
                dtpNgayMuon.Value = Loan.NgayMuon;
                dtpNgayTra.Value = Loan.NgayTra ?? DateTime.Now;
                if (Loan.NgayTra.HasValue && Loan.NgayTra.Value < DateTime.Now)
                {
                    Loan.TrangThai = "Đã Trả";
                }
                cbTrangThai.Text = Loan.TrangThai;
            }
            else
            {
                MessageBox.Show("Dữ liệu mượn sách không hợp lệ.");
            }
        }

        private void LoadLoanStatusOptions()
        {
            cbTrangThai.Items.Add("Đang Mượn");
            cbTrangThai.Items.Add("Đã Trả");
            cbTrangThai.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Loan = new Loan
            {
                Id = Loan?.Id ?? 0,
                TenDangNhap = txtTenDangNhap.Text,
                TieuDe = txtTieuDeSach.Text,
                NgayMuon = dtpNgayMuon.Value,
                NgayTra = dtpNgayTra.Value,
                TrangThai = DetermineLoanStatus()
            };

            using (var context = new LibraryContext())
            {
                if (Loan.Id == 0)
                {
                    context.Loans.Add(Loan);
                }
                else
                {
                    context.Loans.Attach(Loan);
                    context.Entry(Loan).State = EntityState.Modified;
                }
                context.SaveChanges();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string DetermineLoanStatus()
        {
            if (dtpNgayTra.Value < DateTime.Now)
            {
                return "Đã Trả";
            }
            return "Đang Mượn";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
