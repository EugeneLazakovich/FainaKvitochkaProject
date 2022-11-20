using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface IItemKeyWordService
    {
        Task<IEnumerable<ItemKeyWord>> GetAllItemKeyWords();
        Task<ItemKeyWord> GetByIdItemKeyWord(Guid id);
        Task<bool> DeleteByIdItemKeyWord(Guid id);
        Task<bool> UpdateItemKeyWord(ItemKeyWord itemKeyWord);
        Task<Guid> AddItemKeyWord(ItemKeyWord itemKeyWord);
    }
}
