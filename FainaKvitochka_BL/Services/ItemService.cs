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
    public class ItemService : IItemService
    {
        private readonly IGenericRepository<Item> _itemRepository;

        public ItemService(IGenericRepository<Item> itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<Guid> AddItem(Item item)
        {
            return await _itemRepository.Add(item);
        }

        public async Task<bool> DeleteByIdItem(Guid id)
        {
            return await _itemRepository.DeleteById(id);
        }

        public async Task<IEnumerable<Item>> GetAllItems()
        {
            return await _itemRepository.GetAll();
        }

        public async Task<Item> GetByIdItem(Guid id)
        {
            return await _itemRepository.GetById(id);
        }

        public async Task<bool> UpdateItem(Item item)
        {
            return await _itemRepository.Update(item);
        }
    }
}
