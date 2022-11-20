using FainaKvitochka_BL.Interfaces;
using FainaKvitochka_DAL.Interfaces;
using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Services
{
    public class CollectionBaseService : ICollectionBaseService
    {
        private readonly IGenericRepository<CollectionBase> _collectionRepository;

        public CollectionBaseService(IGenericRepository<CollectionBase> collectionRepository)
        {
            _collectionRepository = collectionRepository;
        }

        public async Task<Guid> AddCollection(CollectionBase collectionBase)
        {
            return await _collectionRepository.Add(collectionBase);
        }

        public async Task<bool> DeleteByIdCollection(Guid id)
        {
            return await _collectionRepository.DeleteById(id);
        }

        public async Task<IEnumerable<CollectionBase>> GetAllCollections()
        {
            return await _collectionRepository.GetAll();
        }

        public async Task<CollectionBase> GetByIdCollection(Guid id)
        {
            return await _collectionRepository.GetById(id);
        }

        public async Task<bool> UpdateCollection(CollectionBase collectionBase)
        {
            return await _collectionRepository.Update(collectionBase);
        }
    }
}
