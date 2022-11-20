using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Services.HashService
{
    public interface IHashService
    {
        string HashString(string source);
    }
}
