using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface IItemCollectionBaseService
    {
        Task<IEnumerable<ItemCollectionBase>> GetAllItemCollections();
        Task<ItemCollectionBase> GetByIdItemCollection(Guid id);
        Task<bool> DeleteByIdItemCollection(Guid id);
        Task<bool> UpdateItemCollection(ItemCollectionBase itemCollection);
        Task<Guid> AddItemCollection(ItemCollectionBase itemCollection);
    }
}
