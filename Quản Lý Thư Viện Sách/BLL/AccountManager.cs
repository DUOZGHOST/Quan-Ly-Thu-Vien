using Quản_Lý_Thư_Viện_Sách.DAL;
using Quản_Lý_Thư_Viện_Sách.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viện_Sách.BLL
{
    public class AccountManager
    {
        private AccountRepository _accountRepository;

        public AccountManager()
        {
            _accountRepository = new AccountRepository();
        }

        public Account ValidateUser(string tenDangNhap, string matKhau)
        {
            var account = _accountRepository.GetAllAccounts()
                .FirstOrDefault(a => a.TenDangNhap == tenDangNhap && a.MatKhau == matKhau);

            if (account != null)
            {
                if (account.TenDangNhap == "admin" && account.MatKhau == "admin")
                {
                    account.LaAdmin = true;
                }
                return account;
            }
            return null;
        }

        public bool IsAdmin(Account account)
        {
            return account != null && (account.TenDangNhap == "admin" && account.MatKhau == "admin" || account.LaAdmin);
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return _accountRepository.GetAllAccounts();
        }

        public Account GetAccountById(string tenDangNhap)
        {
            return _accountRepository.GetAccountById(tenDangNhap);
        }

        public void AddAccount(Account account)
        {
            if (_accountRepository.CheckDuplicateUsername(account.TenDangNhap))
            {
                throw new Exception("Tên đăng nhập đã tồn tại.");
            }
            _accountRepository.AddAccount(account);
        }

        public void UpdateAccount(Account account, string newPassword = null)
        {
            if (_accountRepository.CheckDuplicateUsername(account.TenDangNhap, account.TenDangNhap))
            {
                throw new Exception("Tên đăng nhập đã tồn tại.");
            }

            var existingAccount = _accountRepository.GetAccountById(account.TenDangNhap);
            if (existingAccount != null)
            {
                existingAccount.DiaChi = account.DiaChi;
                existingAccount.SoDienThoai = account.SoDienThoai;
                existingAccount.LaAdmin = account.LaAdmin;
                existingAccount.IsActive = account.IsActive;

                if (!string.IsNullOrEmpty(newPassword))
                {
                    if (existingAccount.MatKhau != newPassword)
                    {
                        existingAccount.MatKhau = newPassword;
                    }
                }

                _accountRepository.UpdateAccount(existingAccount);
            }
        }

        public void DeleteAccount(string tenDangNhap)
        {
            _accountRepository.DeleteAccount(tenDangNhap);
        }

        public void RegisterAccount(string hoTen, string diaChi, string soDienThoai, string tenDangNhap, string matKhau)
        {
            if (tenDangNhap.Trim().ToLower() == "admin")
            {
                throw new Exception("Không thể đăng ký tên người dùng là 'admin'.");
            }

            var account = new Account
            {
                TenDangNhap = tenDangNhap,
                DiaChi = diaChi,
                SoDienThoai = soDienThoai,
                MatKhau = matKhau
            };

            AddAccount(account);
        }
    }
}
