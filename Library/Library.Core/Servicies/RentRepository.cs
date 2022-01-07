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
    public class RentRepository : IRentRepository
    {
        private LibraryContext _db;
        public RentRepository(LibraryContext db)
        {
            _db = db;
        }
        public void DeleteRent(Rent rent)
        {
            _db.Entry(rent).State = EntityState.Deleted;
        }

        public void DeleteRentById(int rentId)
        {
            var rent = GetRentById(rentId);
            DeleteRent(rent);
        }

        public IEnumerable<RentViewModel> GetAllRent()
        {
            return _db.Rents
                .Include(r => r.Books)
                .Include(r => r.Users)
                .Select(r => new RentViewModel()
                {
                    RentID=r.RentID,
                    BookName = _db.Books.Single(b => b.BookID == r.BookID).BookName,
                    UserName = _db.Users.Single(u => u.Id == r.UserId).FullName,
                    CountDay = r.CountDay,
                    RentDate = r.GetDate,
                    Price = _db.Books.Single(b => b.BookID == r.BookID).Price * r.CountDay,
                });
        }

        public Rent GetRentById(int rentId)
        {
            return _db.Rents.Find(rentId);
        }

        public void InsertRent(Rent rent)
        {
            var exist_rent = _db.Rents
                 .Any(r => r.BookID == rent.BookID && r.UserId == rent.UserId);
            if (!exist_rent)
            {
                _db.Rents.Add(rent);
            }
            Save();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
