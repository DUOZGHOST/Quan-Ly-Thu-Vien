using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viện_Sách.Models
{
    public class Book
    {
        [Key]
        [StringLength(200)]
        public string TieuDe { get; set; }

        [Required]
        [StringLength(100)]
        public string TacGia { get; set; }

        [Required]
        [StringLength(100)]
        public string DanhMuc { get; set; }

        [Required]
        [StringLength(100)]
        public string NhaXuatBan { get; set; }

        [Required]
        public DateTime NamXuatBan { get; set; }

        [Required]
        public int? SoLuongTonKho { get; set; }

        [Required]
        [StringLength(50)]
        public string TrangThai { get; set; }
    }
}
