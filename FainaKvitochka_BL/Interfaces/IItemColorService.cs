using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface IItemColorService
    {
        Task<IEnumerable<ItemColor>> GetAllItemColors();
        Task<ItemColor> GetByIdItemColor(Guid id);
        Task<bool> DeleteByIdItemColor(Guid id);
        Task<bool> UpdateItemColor(ItemColor itemColor);
        Task<Guid> AddItemColor(ItemColor itemColor);
    }
}
