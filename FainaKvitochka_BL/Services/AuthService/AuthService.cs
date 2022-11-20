using FainaKvitochka_BL.Auth;
using FainaKvitochka_BL.Services.HashService;
using FainaKvitochka_DAL.Interfaces;
using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly IGenericRepository<User> _userRepository;
        private readonly ITokenGenerator _tokenGenerator;
        private readonly IHashService _hashService;
        public AuthService(
            IGenericRepository<User> genericClientRepository,
            ITokenGenerator tokenGenerator,
            IHashService hashService)
        {
            _userRepository = genericClientRepository;
            _tokenGenerator = tokenGenerator;
            _hashService = hashService;
        }

        public async Task<string> SignIn(string login, string password)
        {
            var user = await _userRepository
                .GetByPredicate(c => c.Login == login);

            if (user == null)
            {
                throw new ArgumentException("User didn't find!");
            }

            var hashed = _hashService.HashString(password);
            var fullUser = await _userRepository
                .GetByPredicate(c => c.Login == login && c.Password == hashed);

            if (fullUser == null)
            {
                throw new ArgumentException("Password is incorrect!");
            }

            return _tokenGenerator.GenerateToken(fullUser.Login, "Admin");
        }

        public async Task<Guid> SignUp(User user)
        {
            var userDB = await _userRepository.GetByPredicate(x => x.Login == user.Login);
            if (userDB != null)
            {
                throw new ArgumentException("User with this email has already been created!");
            }
            user.Password = _hashService.HashString(user.Password);

            var response = await _userRepository.Add(user);

            return response;
        }
    }
}
