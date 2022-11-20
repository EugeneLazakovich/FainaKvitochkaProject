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
    public class NewsService : INewsService
    {
        private readonly IGenericRepository<News> _newsRepository;

        public NewsService(IGenericRepository<News> newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public async Task<Guid> AddNews(News news)
        {
            return await _newsRepository.Add(news);
        }

        public async Task<bool> DeleteByIdNews(Guid id)
        {
            return await _newsRepository.DeleteById(id);
        }

        public async Task<IEnumerable<News>> GetAllNews()
        {
            return await _newsRepository.GetAll();
        }

        public async Task<News> GetByIdNews(Guid id)
        {
            return await _newsRepository.GetById(id);
        }

        public async Task<bool> UpdateNews(News news)
        {
            return await _newsRepository.Update(news);
        }
    }
}
