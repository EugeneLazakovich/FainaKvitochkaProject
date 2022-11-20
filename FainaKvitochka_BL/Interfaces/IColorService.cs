using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface IColorService
    {
        Task<IEnumerable<Color>> GetAllColors();
        Task<Color> GetByIdColor(Guid id);
        Task<bool> DeleteByIdColor(Guid id);
        Task<bool> UpdateColor(Color color);
        Task<Guid> AddColor(Color color);
    }
}
