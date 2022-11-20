using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetByIdCategory(Guid id);
        Task<bool> DeleteByIdCategory(Guid id);
        Task<bool> UpdateCategory(Category category);
        Task<Guid> AddCategory(Category category);
    }
}
