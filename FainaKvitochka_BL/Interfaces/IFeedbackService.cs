using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface IFeedbackService
    {
        Task<IEnumerable<Feedback>> GetAllFeedbacks();
        Task<Feedback> GetByIdFeedback(Guid id);
        Task<bool> DeleteByIdFeedback(Guid id);
        Task<bool> UpdateFeedback(Feedback feedback);
        Task<Guid> AddFeedback(Feedback feedback);
    }
}
