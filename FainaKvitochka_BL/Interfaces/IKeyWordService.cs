using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface IKeyWordService
    {
        Task<IEnumerable<KeyWord>> GetAllKeyWords();
        Task<KeyWord> GetByIdKeyWord(Guid id);
        Task<bool> DeleteByIdKeyWord(Guid id);
        Task<bool> UpdateKeyWord(KeyWord keyWord);
        Task<Guid> AddKeyWord(KeyWord keyWord);
    }
}
