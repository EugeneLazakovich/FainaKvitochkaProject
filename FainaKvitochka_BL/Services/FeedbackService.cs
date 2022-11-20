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
    public class FeedbackService : IFeedbackService
    {
        private readonly IGenericRepository<Feedback> _feedbackRepository;

        public FeedbackService(IGenericRepository<Feedback> feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        public async Task<Guid> AddFeedback(Feedback feedback)
        {
            return await _feedbackRepository.Add(feedback);
        }

        public async Task<bool> DeleteByIdFeedback(Guid id)
        {
            return await _feedbackRepository.DeleteById(id);
        }

        public async Task<IEnumerable<Feedback>> GetAllFeedbacks()
        {
            return await _feedbackRepository.GetAll();
        }

        public async Task<Feedback> GetByIdFeedback(Guid id)
        {
            return await _feedbackRepository.GetById(id);
        }

        public async Task<bool> UpdateFeedback(Feedback feedback)
        {
            return await _feedbackRepository.Update(feedback);
        }
    }
}
