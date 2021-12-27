using Library.Core.DTOs;
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
    public class BookGroupRepository:IBookGroupRepository
    {
        private LibraryContext _db;
        public BookGroupRepository(LibraryContext db)
        {
            _db = db;
        }
        public void DeleteBookGroup(BookGroup bookGroup)
        {
            _db.Entry(bookGroup).State = EntityState.Deleted;
        }

        public void DeleteBookGroupById(int groupId)
        {
            var group = GetBookGroupById(groupId);
            DeleteBookGroup(group);
        }

        public List<BookGroup> GetAllBookGroups()
        {
            return _db.BookGroups.ToList();
        }

        public BookGroup GetBookGroupById(int groupId)
        {
            return _db.BookGroups.Find(groupId);
        }

        public void InsertBookGroup(BookGroup bookGroup)
        {
            _db.BookGroups.Add(bookGroup);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void UpdateBookGroup(BookGroup bookGroup)
        {
            _db.Entry(bookGroup).State = EntityState.Modified;
        }
        public List<ShowGroupsViewModels> GetListGroups()
        {
            return _db.BookGroups.Select(g => new ShowGroupsViewModels()
            {
                GroupId = g.GroupID,
                GroupTiltle = g.GroupTitle,
                GroupCount = g.Books.Count
            }).ToList();
        }
        public bool IsExistsBookGroup(int groupId)
        {
            return _db.BookGroups.Any(p => p.GroupID == groupId);
        }
    }
}
