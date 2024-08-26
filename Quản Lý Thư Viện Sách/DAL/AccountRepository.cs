using System;
using Quản_Lý_Thư_Viện_Sách.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Quản_Lý_Thư_Viện_Sách.DAL
{
    public class AccountRepository
    {
        private LibraryContext _context;

        public AccountRepository()
        {
            _context = new LibraryContext();
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return _context.Accounts.ToList();
        }

        public Account GetAccountById(string tenDangNhap)
        {
            return _context.Accounts.FirstOrDefault(a => a.TenDangNhap == tenDangNhap);
        }

        public void AddAccount(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void UpdateAccount(Account account)
        {
            _context.Entry(account).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteAccount(string tenDangNhap)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.TenDangNhap == tenDangNhap);
            if (account != null)
            {
                _context.Accounts.Remove(account);
                _context.SaveChanges();
            }
        }

        public bool IsAdminAccount(string tenDangNhap, string matKhau)
        {
            return tenDangNhap == "admin" && matKhau == "admin";
        }

        public bool CheckDuplicateUsername(string tenDangNhap, string excludeTenDangNhap = null)
        {
            var existingAccount = _context.Accounts.FirstOrDefault(a => a.TenDangNhap == tenDangNhap && a.TenDangNhap != excludeTenDangNhap);
            return existingAccount != null;
        }
    }
}
