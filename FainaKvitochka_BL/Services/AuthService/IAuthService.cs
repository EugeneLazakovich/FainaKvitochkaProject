using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Services.AuthService
{
    public interface IAuthService
    {
        Task<string> SignIn(string login, string password);
        Task<Guid> SignUp(User user);
    }
}
