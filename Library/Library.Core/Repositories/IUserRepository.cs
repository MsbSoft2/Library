using Library.Core.DTOs;
using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUser();
        Task<User> GetUserById(int? id);
        Task Create(User user);
        Task Update(User user);
        Task Remove(User user);
        Task<bool> UserExists(int id);
        Task<User> Login(LoginViewModel login);
    }
}
