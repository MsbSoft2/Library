using Library.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int? id);
        Task<bool> Insert(User user);
        Task<bool> Update(User user);
        Task<bool> Delete(int id);
        Task<bool> Delete(User user);
        Task<bool> IsExist(int? id);
    }
}
