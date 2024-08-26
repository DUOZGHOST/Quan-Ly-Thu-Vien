using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viện_Sách.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(200)]
        public string TieuDe { get; set; }

        [Required]
        public DateTime NgayMuon { get; set; }

        public DateTime? NgayTra { get; set; }

        [Required]
        [StringLength(20)]
        public string TrangThai { get; set; }

        [ForeignKey("TenDangNhap")]
        public virtual Account Account { get; set; }

        [ForeignKey("TieuDe")]
        public virtual Book Book { get; set; }
    }
}
