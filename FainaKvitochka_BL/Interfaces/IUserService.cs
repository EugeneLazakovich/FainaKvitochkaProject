using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetByIdUser(Guid id);
        Task<bool> DeleteByIdUser(Guid id);
        Task<bool> UpdateUser(User user);
        Task<Guid> AddUser(User user);

    }
}
