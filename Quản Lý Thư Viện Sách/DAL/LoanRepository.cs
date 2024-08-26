using System;
using Quản_Lý_Thư_Viện_Sách.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Quản_Lý_Thư_Viện_Sách.DAL
{
    public class LoanRepository
    {
        private LibraryContext _context;

        public LoanRepository()
        {
            _context = new LibraryContext();
        }

        public IEnumerable<Loan> GetAllLoans()
        {
            return _context.Loans.ToList();
        }

        public Loan GetLoanById(int id)
        {
            return _context.Loans.Find(id);
        }

        public void AddLoan(Loan loan)
        {
            _context.Loans.Add(loan);
            _context.SaveChanges();
        }

        public void UpdateLoan(Loan loan)
        {
            _context.Entry(loan).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteLoan(int id)
        {
            var loan = _context.Loans.Find(id);
            if (loan != null)
            {
                _context.Loans.Remove(loan);
                _context.SaveChanges();
            }
        }
    }
}
