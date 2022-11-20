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
    public class FormService : IFormService
    {
        private readonly IGenericRepository<Form> _formRepository;

        public FormService(IGenericRepository<Form> formRepository)
        {
            _formRepository = formRepository;
        }

        public async Task<Guid> AddForm(Form form)
        {
            return await _formRepository.Add(form);
        }

        public async Task<bool> DeleteByIdForm(Guid id)
        {
            return await _formRepository.DeleteById(id);
        }

        public async Task<IEnumerable<Form>> GetAllForms()
        {
            return await _formRepository.GetAll();
        }

        public async Task<Form> GetByIdForm(Guid id)
        {
            return await _formRepository.GetById(id);
        }

        public async Task<bool> UpdateForm(Form form)
        {
            return await _formRepository.Update(form);
        }
    }
}
