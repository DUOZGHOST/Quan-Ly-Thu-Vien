using System;
using Quản_Lý_Thư_Viện_Sách.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace Quản_Lý_Thư_Viện_Sách.DAL
{
    public class ReportRepository
    {
        private LibraryContext _context;

        public ReportRepository(LibraryContext context)
        {
            _context = context;
        }

        public int GetTotalBooks() => _context.Books.Count();

        public int GetTotalLoanedBooks() => _context.Loans.Count(l => l.NgayTra == null);

        public int GetAvailableBooks() => _context.Books.Sum(b => b.SoLuongTonKho ?? 0) - GetTotalLoanedBooks();

        public int GetOverdueBooks()
        {
            var overdueDate = DateTime.Now.AddDays(-30);
            return _context.Loans.Count(l => l.NgayTra == null && l.NgayMuon < overdueDate);
        }

        public int GetTotalAccounts() => _context.Accounts.Count();

        public int GetActiveAccounts() => _context.Accounts.Count(a => a.IsActive);

        public int GetInactiveAccounts() => _context.Accounts.Count(a => !a.IsActive);

        public decimal GetTotalFines()
        {
            const decimal finePerDay = 5000m;

            var today = DateTime.Now;

            var loans = _context.Loans
            .Where(l => l.NgayTra == null)
            .ToList();

            if (loans == null)
            {
                throw new InvalidOperationException("Không có dữ liệu khoản mượn sách.");
            }

            var totalFines = loans
                .Select(l =>
                    Math.Max((today - l.NgayMuon).Days, 0) * finePerDay
                )
                .Sum();

            return totalFines;
        }

        public List<ChiTietSachMuon> GetLoanDetails()
        {
            var today = DateTime.Now;

            var loans = _context.Loans
                .Include(l => l.Book) 
                .Include(l => l.Account)
                .ToList();

            var loanDetails = loans
                .Select(l => new ChiTietSachMuon
                {
                    TenDangNhap = l.Account.TenDangNhap,
                    TieuDeSach = l.Book.TieuDe,
                    NgayMuon = l.NgayMuon,
                    NgayTra = l.NgayTra,
                    TrangThai = l.TrangThai
                })
                .ToList();

            return loanDetails;
        }
    }
}
