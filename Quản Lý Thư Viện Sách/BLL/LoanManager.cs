using Quản_Lý_Thư_Viện_Sách.DAL;
using Quản_Lý_Thư_Viện_Sách.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viện_Sách.BLL
{
    public class LoanManager
    {
        private LoanRepository _loanRepository;

        public LoanManager()
        {
            _loanRepository = new LoanRepository();
        }

        public IEnumerable<Loan> GetAllLoans()
        {
            return _loanRepository.GetAllLoans();
        }

        public IEnumerable<Loan> GetAllLoansForAccount(string tenDangNhap)
        {
            return _loanRepository.GetAllLoans().Where(loan => loan.TenDangNhap == tenDangNhap);
        }

        public Loan GetLoanById(int id)
        {
            return _loanRepository.GetLoanById(id);
        }

        public void AddLoan(Loan loan)
        {
            _loanRepository.AddLoan(loan);
        }

        public void UpdateLoan(Loan loan)
        {
            _loanRepository.UpdateLoan(loan);
        }

        public void DeleteLoan(int id)
        {
            _loanRepository.DeleteLoan(id);
        }

        public IEnumerable<Loan> GetLoansByDateRange(DateTime startDate, DateTime endDate)
        {
            return _loanRepository.GetAllLoans()
                .Where(l => l.NgayMuon >= startDate && l.NgayMuon <= endDate).ToList();
        }

        public void UpdateOverdueLoans()
        {
            var loans = _loanRepository.GetAllLoans()
                .Where(l => l.TrangThai == "Đang mượn" && l.NgayTra == null)
                .ToList();

            foreach (var loan in loans)
            {
                var dueDate = loan.NgayMuon.AddDays(30);
                if (DateTime.Now > dueDate)
                {
                    loan.TrangThai = "Quá hạn";
                    _loanRepository.UpdateLoan(loan);
                }
            }
        }

    }
}
