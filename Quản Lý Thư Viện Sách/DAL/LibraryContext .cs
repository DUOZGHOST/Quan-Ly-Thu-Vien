using Quản_Lý_Thư_Viện_Sách.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viện_Sách.DAL
{
    public class LibraryContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<ChiTietSachMuon> ChiTietSachMuons { get; set; }

        public LibraryContext() : base("name=LibraryContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Report>().HasKey(r => r.Id);
            modelBuilder.Entity<ChiTietSachMuon>().HasKey(c => c.Id);

            modelBuilder.Entity<Loan>()
                .HasRequired(l => l.Account)
                .WithMany()
                .HasForeignKey(l => l.TenDangNhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Loan>()
                .HasRequired(l => l.Book)
                .WithMany()
                .HasForeignKey(l => l.TieuDe)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
