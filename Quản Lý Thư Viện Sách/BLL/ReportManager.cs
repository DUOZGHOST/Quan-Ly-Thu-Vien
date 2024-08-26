using iTextSharp.text.pdf;
using iTextSharp.text;
using Quản_Lý_Thư_Viện_Sách.DAL;
using Quản_Lý_Thư_Viện_Sách.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viện_Sách.BLL
{
    public class ReportManager
    {
        private ReportRepository _reportRepository;

        public ReportManager(ReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public Report GenerateReport()
        {
            var report = new Report
            {
                NgayBaoCao = DateTime.Now,
                TongSoSach = _reportRepository.GetTotalBooks(),
                TongSoSachDaMuon = _reportRepository.GetTotalLoanedBooks(),
                TongSoSachConLai = _reportRepository.GetAvailableBooks(),
                TongSoSachQuaHan = _reportRepository.GetOverdueBooks(),
                TongSoTaiKhoan = _reportRepository.GetTotalAccounts(),
                TongSoTaiKhoanHoatDong = _reportRepository.GetActiveAccounts(),
                TongSoTaiKhoanKhongHoatDong = _reportRepository.GetInactiveAccounts(),
            };

            report.ChiTietSachMuons = _reportRepository.GetLoanDetails();

            return report;
        }

        public void GeneratePdf(Report report, string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (Document doc = new Document(PageSize.A4))
                    {
                        PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        doc.Add(new Paragraph("Bao cao thu vien"));
                        doc.Add(new Paragraph("Ngay bao cao: " + report.NgayBaoCao.ToString("dd/MM/yyyy")));
                        doc.Add(new Paragraph(""));

                        doc.Add(new Paragraph("Tong so sach: " + report.TongSoSach));
                        doc.Add(new Paragraph("Tong so luong sach da muon: " + report.TongSoSachDaMuon));
                        doc.Add(new Paragraph("Tong so luong sach con lai: " + report.TongSoSachConLai));
                        doc.Add(new Paragraph(""));

                        doc.Add(new Paragraph("Tong so luong sach qua han: " + report.TongSoSachQuaHan));
                        doc.Add(new Paragraph("Tong so tai khoan: " + report.TongSoTaiKhoan));
                        doc.Add(new Paragraph("Tong so tai khoan hoat dong: " + report.TongSoTaiKhoanHoatDong));
                        doc.Add(new Paragraph("Tong so tai khoan khong hoat dong: " + report.TongSoTaiKhoanKhongHoatDong));
                        doc.Add(new Paragraph(""));

                        doc.Add(new Paragraph("Chi tiet sach muon: "));
                        doc.Add(new Paragraph(""));
                        PdfPTable loanTable = new PdfPTable(2);
                        loanTable.AddCell("Ten sach");
                        loanTable.AddCell("Ten nguoi muon");
                        foreach (var item in report.ChiTietSachMuons)
                        {
                            loanTable.AddCell(item.TieuDeSach);
                            loanTable.AddCell(item.TenDangNhap);
                        }
                        doc.Add(loanTable);

                        doc.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Lỗi tạo PDF", ex);
            }
        }
    }
}
