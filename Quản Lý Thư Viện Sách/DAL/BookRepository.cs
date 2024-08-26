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
    public class BookRepository
    {
        private LibraryContext _context;

        public BookRepository()
        {
            _context = new LibraryContext();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBookById(string tieuDe)
        {
            return _context.Books.FirstOrDefault(b => b.TieuDe == tieuDe);
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteBook(string tieuDe)
        {
            var book = _context.Books.FirstOrDefault(b => b.TieuDe == tieuDe);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
