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
    public class ItemCollectionBaseService : IItemCollectionBaseService
    {
        private readonly IGenericRepository<ItemCollectionBase> _itemCollectionRepository;

        public ItemCollectionBaseService(IGenericRepository<ItemCollectionBase> itemCollectionRepository)
        {
            _itemCollectionRepository = itemCollectionRepository;
        }

        public async Task<Guid> AddItemCollection(ItemCollectionBase itemCollection)
        {
            return await _itemCollectionRepository.Add(itemCollection);
        }

        public async Task<bool> DeleteByIdItemCollection(Guid id)
        {
            return await _itemCollectionRepository.DeleteById(id);
        }

        public async Task<IEnumerable<ItemCollectionBase>> GetAllItemCollections()
        {
            return await _itemCollectionRepository.GetAll();
        }

        public async Task<ItemCollectionBase> GetByIdItemCollection(Guid id)
        {
            return await _itemCollectionRepository.GetById(id);
        }

        public async Task<bool> UpdateItemCollection(ItemCollectionBase itemCollection)
        {
            return await _itemCollectionRepository.Update(itemCollection);
        }
    }
}
