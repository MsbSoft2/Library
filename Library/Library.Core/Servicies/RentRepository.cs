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

        public List<Rent> GetAllRent()
        {
            return _db.Rents.ToList();
        }

        public Rent GetRentById(int rentId)
        {
            return _db.Rents.Find(rentId);
        }

        public void InsertRent(Rent rent)
        {
            _db.Rents.Add(rent);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
