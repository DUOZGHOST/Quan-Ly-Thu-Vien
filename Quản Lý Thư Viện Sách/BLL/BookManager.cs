using Quản_Lý_Thư_Viện_Sách.DAL;
using Quản_Lý_Thư_Viện_Sách.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viện_Sách.BLL
{
    public class BookManager
    {
        private BookRepository _bookRepository;

        public BookManager()
        {
            _bookRepository = new BookRepository();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public Book GetBookById(string tieuDe)
        {
            return _bookRepository.GetBookById(tieuDe);
        }

        public void AddBook(Book book)
        {
            _bookRepository.AddBook(book);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.UpdateBook(book);
        }

        public void DeleteBook(string tieuDe)
        {
            _bookRepository.DeleteBook(tieuDe);
        }
    }
}
