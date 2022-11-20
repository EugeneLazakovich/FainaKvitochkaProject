using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface ICollectionBaseService
    {
        Task<IEnumerable<CollectionBase>> GetAllCollections();
        Task<CollectionBase> GetByIdCollection(Guid id);
        Task<bool> DeleteByIdCollection(Guid id);
        Task<bool> UpdateCollection(CollectionBase collection);
        Task<Guid> AddCollection(CollectionBase collection);
    }
}
