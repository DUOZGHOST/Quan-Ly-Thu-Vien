using System;
using System.IO;
using Quản_Lý_Thư_Viện_Sách.BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quản_Lý_Thư_Viện_Sách.Models;
using Quản_Lý_Thư_Viện_Sách.DAL;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Quản_Lý_Thư_Viện_Sách.Presentation.Admin
{
    public partial class ReportForm : Form
    {
        private ReportManager _reportManager;
        private Report _currentReport;

        public ReportForm()
        {
            InitializeComponent();
            var context = new LibraryContext();
            var reportRepository = new ReportRepository(context);
            _reportManager = new ReportManager(reportRepository);
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            _currentReport = _reportManager.GenerateReport();

            lblNgayBaoCao.Text = "Ngày báo cáo: " + _currentReport.NgayBaoCao.ToString("dd/MM/yyyy");
            lblTongSoSach.Text = "Tổng số sách: " + _currentReport.TongSoSach;
            lblTongSoSachDaMuon.Text = "Tổng số lượng sách đã mượn: " + _currentReport.TongSoSachDaMuon;
            lblTongSoSachConLai.Text = "Tổng số lượng sách còn lại: " + _currentReport.TongSoSachConLai;
            lblTongSoSachQuaHan.Text = "Tổng số lượng sách quá hạn: " + _currentReport.TongSoSachQuaHan;
            lblTongSoTaiKhoan.Text = "Tổng số tài khoản: " + _currentReport.TongSoTaiKhoan;
            lblTongSoTaiKhoanHoatDong.Text = "Tổng số tài khoản hoạt động: " + _currentReport.TongSoTaiKhoanHoatDong;
            lblTongSoTaiKhoanKhongHoatDong.Text = "Tổng số tài khoản không hoạt động: " + _currentReport.TongSoTaiKhoanKhongHoatDong;

            LoadChiTietSachMuons();
        }

        private void LoadChiTietSachMuons()
        {
            lstChiTietSachMuons.Columns.Clear();
            lstChiTietSachMuons.Columns.Add("Tên sách", 300);
            lstChiTietSachMuons.Columns.Add("Tên người mượn", 150);

            lstChiTietSachMuons.Items.Clear();
            foreach (var item in _currentReport.ChiTietSachMuons)
            {
                var listViewItem = new ListViewItem(new[] { item.TieuDeSach, item.TenDangNhap });
                lstChiTietSachMuons.Items.Add(listViewItem);
            }
        }

        private void btnGeneratePdf_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = $"BaoCao_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                _reportManager.GeneratePdf(_currentReport, filePath);
                MessageBox.Show($"Báo cáo đã được tạo thành công tại {filePath}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tạo báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
