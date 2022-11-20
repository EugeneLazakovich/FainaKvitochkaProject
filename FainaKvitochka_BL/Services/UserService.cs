using FainaKvitochka_BL.Interfaces;
using FainaKvitochka_DAL.Interfaces;
using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _userRepository;

        public UserService(IGenericRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Guid> AddUser(User user)
        {
            return await _userRepository.Add(user);
        }

        public async Task<bool> DeleteByIdUser(Guid id)
        {
            return await _userRepository.DeleteById(id);
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _userRepository.GetAll();
        }

        public async Task<User> GetByIdUser(Guid id)
        {
            return await _userRepository.GetById(id);
        }

        public async Task<bool> UpdateUser(User user)
        {
            return await _userRepository.Update(user);
        }
    }
}
