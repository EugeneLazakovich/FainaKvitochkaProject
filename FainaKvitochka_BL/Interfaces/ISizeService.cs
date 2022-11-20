using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface ISizeService
    {
        Task<IEnumerable<Size>> GetAllSizes();
        Task<Size> GetByIdSize(Guid id);
        Task<bool> DeleteByIdSize(Guid id);
        Task<bool> UpdateSize(Size size);
        Task<Guid> AddSize(Size size);
    }
}
