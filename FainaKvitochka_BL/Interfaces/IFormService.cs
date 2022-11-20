using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface IFormService
    {
        Task<IEnumerable<Form>> GetAllForms();
        Task<Form> GetByIdForm(Guid id);
        Task<bool> DeleteByIdForm(Guid id);
        Task<bool> UpdateForm(Form form);
        Task<Guid> AddForm(Form form);
    }
}
