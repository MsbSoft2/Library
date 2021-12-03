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
    public class UserRepository : IUserRepository
    {
        private LibraryContext _context;
        public UserRepository(LibraryContext context)
        {
            _context = context;
        }

        public async Task Create(User user)
        {
            user.RegisterDate = DateTime.Now;
            _context.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllUser()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserById(int? id)
        {
            return await _context.Users
                 .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task Remove(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task Update(User user)
        {
            _context.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UserExists(int id)
        {
            return await _context.Users.AnyAsync(e => e.Id == id);
        }
    }
}
