using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IRentRepository
    {
        List<Rent> GetAllRent();
        Rent GetRentById(int rentId);
        void InsertRent(Rent rent);
        void DeleteRent(Rent rent);
        void DeleteRentById(int rentId);
        void Save();
    }
}
