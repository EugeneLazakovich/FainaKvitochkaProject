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
    public class CategoryService : ICategoryService
    {
        private readonly IGenericRepository<Category> _categoryRepository;

        public CategoryService(IGenericRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Guid> AddCategory(Category category)
        {
            return await _categoryRepository.Add(category);
        }

        public async Task<bool> DeleteByIdCategory(Guid id)
        {
            return await _categoryRepository.DeleteById(id);
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _categoryRepository.GetAll();
        }

        public async Task<Category> GetByIdCategory(Guid id)
        {
            return await _categoryRepository.GetById(id);
        }

        public async Task<bool> UpdateCategory(Category category)
        {
            return await _categoryRepository.Update(category);
        }
    }
}
