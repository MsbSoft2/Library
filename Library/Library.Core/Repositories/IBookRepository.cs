using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        IEnumerable<Book> GetTopBooks(int take = 4);
        IEnumerable<Book> GetSlider();
        IEnumerable<Book> GetLastBooks();
        IEnumerable<Book> GetBooksByGroupId(int groupId);
        IEnumerable<Book> SearchInBooksByParameter(string parameter);
        Book GetBookById(int bookId);
        void InsertBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Book book);
        void DeleteBookById(int bookId);
        bool BookExsist(int pageId);
        void Save();
    }
}
