using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface IItemFeedbackService
    {
        Task<IEnumerable<ItemFeedback>> GetAllItemFeedbacks();
        Task<ItemFeedback> GetByIdItemFeedback(Guid id);
        Task<bool> DeleteByIdItemFeedback(Guid id);
        Task<bool> UpdateItemFeedback(ItemFeedback itemFeedback);
        Task<Guid> AddItemFeedback(ItemFeedback itemFeedback);
    }
}
