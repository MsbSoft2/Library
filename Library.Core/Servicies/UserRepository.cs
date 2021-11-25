using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Core.Repositories;
using Library.Domain.Context;
using Library.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Core.Servicies
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryContext _context;
        public UserRepository(LibraryContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToListAsync<User>();
        }

        public async Task<User> GetById(int? id)
        {
            return await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<bool> Insert(User user)
        {
            try
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Update(User user)
        {
            try
            {
                _context.Update(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> Delete(int id)
        {
            try
            {
                var user = await GetById(id);
                await Delete(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Delete(User user)
        {
            try
            {
                _context.Remove(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> IsExist(int? id)
        {
            return await _context.Users.AnyAsync(u => u.Id == id);
        }
    }
}