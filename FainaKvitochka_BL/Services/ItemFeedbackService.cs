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
    public class ItemFeedbackService : IItemFeedbackService
    {
        private readonly IGenericRepository<ItemFeedback> _itemFeedbackRepository;

        public ItemFeedbackService(IGenericRepository<ItemFeedback> itemFeedbackRepository)
        {
            _itemFeedbackRepository = itemFeedbackRepository;
        }

        public async Task<Guid> AddItemFeedback(ItemFeedback itemFeedback)
        {
            return await _itemFeedbackRepository.Add(itemFeedback);
        }

        public async Task<bool> DeleteByIdItemFeedback(Guid id)
        {
            return await _itemFeedbackRepository.DeleteById(id);
        }

        public async Task<IEnumerable<ItemFeedback>> GetAllItemFeedbacks()
        {
            return await _itemFeedbackRepository.GetAll();
        }

        public async Task<ItemFeedback> GetByIdItemFeedback(Guid id)
        {
            return await _itemFeedbackRepository.GetById(id);
        }

        public async Task<bool> UpdateItemFeedback(ItemFeedback itemFeedback)
        {
            return await _itemFeedbackRepository.Update(itemFeedback);
        }
    }
}
