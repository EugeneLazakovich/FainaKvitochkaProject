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
    public class ColorService : IColorService
    {
        private readonly IGenericRepository<Color> _colorRespoitory;

        public ColorService(IGenericRepository<Color> colorRespoitory)
        {
            _colorRespoitory = colorRespoitory;
        }

        public async Task<Guid> AddColor(Color color)
        {
            return await _colorRespoitory.Add(color);
        }

        public async Task<bool> DeleteByIdColor(Guid id)
        {
            return await _colorRespoitory.DeleteById(id);
        }

        public async Task<IEnumerable<Color>> GetAllColors()
        {
            return await _colorRespoitory.GetAll();
        }

        public async Task<Color> GetByIdColor(Guid id)
        {
            return await _colorRespoitory.GetById(id);
        }

        public async Task<bool> UpdateColor(Color color)
        {
            return await _colorRespoitory.Update(color);
        }
    }
}
