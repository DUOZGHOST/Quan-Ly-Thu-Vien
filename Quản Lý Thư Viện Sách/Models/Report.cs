using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viện_Sách.Models
{
    public class Report
    {
        [Key]
        public int Id { get; set; }

        public DateTime NgayBaoCao { get; set; }

        // Tổng số sách hiện có trong thư viện
        public int TongSoSach { get; set; }

        // Tổng số sách đã mượn
        public int TongSoSachDaMuon { get; set; }

        // Tổng số sách còn lại trong kho
        public int TongSoSachConLai { get; set; }

        // Tổng số sách quá hạn chưa trả
        public int TongSoSachQuaHan { get; set; }

        // Tổng số tài khoản trong hệ thống
        public int TongSoTaiKhoan { get; set; }

        // Tổng số tài khoản đang hoạt động
        public int TongSoTaiKhoanHoatDong { get; set; }

        // Tổng số tài khoản bị khóa hoặc không hoạt động
        public int TongSoTaiKhoanKhongHoatDong { get; set; }

        // Danh sách chi tiết các sách đã mượn
        public List<ChiTietSachMuon> ChiTietSachMuons { get; set; }

        public Report()
        {
            ChiTietSachMuons = new List<ChiTietSachMuon>();
        }
    }

    public class ChiTietSachMuon
    {
        [Key]
        public int Id { get; set; }
        public string TenDangNhap { get; set; }
        public string TieuDeSach { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime? NgayTra { get; set; }
        public string TrangThai { get; set; }
    }
}
