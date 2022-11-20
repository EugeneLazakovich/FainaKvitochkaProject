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
    public class KeyWordService : IKeyWordService
    {
        private readonly IGenericRepository<KeyWord> _keyWordRepository;

        public KeyWordService(IGenericRepository<KeyWord> keyWordRepository)
        {
            _keyWordRepository = keyWordRepository;
        }

        public async Task<Guid> AddKeyWord(KeyWord keyWord)
        {
            return await _keyWordRepository.Add(keyWord);
        }

        public async Task<bool> DeleteByIdKeyWord(Guid id)
        {
            return await _keyWordRepository.DeleteById(id);
        }

        public async Task<IEnumerable<KeyWord>> GetAllKeyWords()
        {
            return await _keyWordRepository.GetAll();
        }

        public async Task<KeyWord> GetByIdKeyWord(Guid id)
        {
            return await _keyWordRepository.GetById(id);
        }

        public async Task<bool> UpdateKeyWord(KeyWord keyWord)
        {
            return await _keyWordRepository.Update(keyWord);
        }
    }
}
