using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Auth
{
    public interface ITokenGenerator
    {
        public string GenerateToken(string username, string role);
        string GetClaimValueFromToken(string jwtToken, string claimsTypeToGet);
    }
}
