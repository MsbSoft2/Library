using Library.Core.Repositories;
using Library.Domain.Context;
using Library.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Servicies
{
    public class BookRepository:IBookRepository
    {
        private LibraryContext _db;
        public BookRepository(LibraryContext db)
        {
            _db = db;
        }
        public void DeleteBook(Book book)
        {
            _db.Entry(book).State = EntityState.Deleted;
        }

        public void DeleteBookById(int bookId)
        {
            var book = GetBookById(bookId);
            DeleteBook(book);
        }

        public List<Book> GetAllBooks()
        {
            return _db.Books.Include(p => p.BookGroup).ToList();
        }


        public Book GetBookById(int bookId)
        {
            return _db.Books.Find(bookId);
        }

        public IEnumerable<Book> GetSlider()
        {
            return _db.Books.Where(p => p.ShowInSlider).ToList();
        }

        public void InsertBook(Book book)
        {
            _db.Books.Add(book);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IEnumerable<Book> SearchInBooksByParameter(string parameter)
        {
            var list = _db.Books.Where(p => p.BookName.Contains(parameter) || p.Author.Contains(parameter) ||
              p.PublisherName.Contains(parameter)).ToList();
            return list.Distinct().ToList();
        }

        public void UpdateBook(Book book)
        {
            _db.Entry(book).State = EntityState.Modified;
        }
        public IEnumerable<Book> GetLastBooks()
        {
            return _db.Books.OrderBy(p => p.PublishYear).Take(3).ToList();
        }
        public IEnumerable<Book> GetBooksByGroupId(int groupId)
        {
            return _db.Books.Where(p => p.GroupID == groupId).ToList();
        }
        public IEnumerable<Book> GetTopBooks(int take = 4)
        {
            return _db.Books.OrderBy(p => p.BookVisit).Take(take).ToList();
        }
        public bool BookExsist(int pageId)
        {
            return _db.Books.Any(p => p.BookID == pageId);
        }
    }
}
