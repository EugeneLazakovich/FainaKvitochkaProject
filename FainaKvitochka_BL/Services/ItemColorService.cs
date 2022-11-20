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
    public class ItemColorService : IItemColorService
    {
        private readonly IGenericRepository<ItemColor> _itemColorRepository;

        public ItemColorService(IGenericRepository<ItemColor> itemColorRepository)
        {
            _itemColorRepository = itemColorRepository;
        }

        public async Task<Guid> AddItemColor(ItemColor itemColor)
        {
            return await _itemColorRepository.Add(itemColor);
        }

        public async Task<bool> DeleteByIdItemColor(Guid id)
        {
            return await _itemColorRepository.DeleteById(id);
        }

        public async Task<IEnumerable<ItemColor>> GetAllItemColors()
        {
            return await _itemColorRepository.GetAll();
        }

        public async Task<ItemColor> GetByIdItemColor(Guid id)
        {
            return await _itemColorRepository.GetById(id);
        }

        public async Task<bool> UpdateItemColor(ItemColor itemColor)
        {
            return await _itemColorRepository.Update(itemColor);
        }
    }
}
