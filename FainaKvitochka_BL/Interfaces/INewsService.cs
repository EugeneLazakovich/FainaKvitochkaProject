using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface INewsService
    {
        Task<IEnumerable<News>> GetAllNews();
        Task<News> GetByIdNews(Guid id);
        Task<bool> DeleteByIdNews(Guid id);
        Task<bool> UpdateNews(News news);
        Task<Guid> AddNews(News news);
    }
}
