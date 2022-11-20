using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetAllItems();
        Task<Item> GetByIdItem(Guid id);
        Task<bool> DeleteByIdItem(Guid id);
        Task<bool> UpdateItem(Item item);
        Task<Guid> AddItem(Item item);
    }
}
