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
    public class ItemKeyWordService : IItemKeyWordService
    {
        private readonly IGenericRepository<ItemKeyWord> _itemKeyWordRepository;

        public ItemKeyWordService(IGenericRepository<ItemKeyWord> itemKeyWordRepository)
        {
            _itemKeyWordRepository = itemKeyWordRepository;
        }

        public async Task<Guid> AddItemKeyWord(ItemKeyWord itemKeyWord)
        {
            return await _itemKeyWordRepository.Add(itemKeyWord);
        }

        public async Task<bool> DeleteByIdItemKeyWord(Guid id)
        {
            return await _itemKeyWordRepository.DeleteById(id);
        }

        public async Task<IEnumerable<ItemKeyWord>> GetAllItemKeyWords()
        {
            return await _itemKeyWordRepository.GetAll();
        }

        public async Task<ItemKeyWord> GetByIdItemKeyWord(Guid id)
        {
            return await _itemKeyWordRepository.GetById(id);
        }

        public async Task<bool> UpdateItemKeyWord(ItemKeyWord itemKeyWord)
        {
            return await _itemKeyWordRepository.Update(itemKeyWord);
        }
    }
}
