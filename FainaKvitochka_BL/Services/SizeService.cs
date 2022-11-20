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
    public class SizeService : ISizeService
    {
        private readonly IGenericRepository<Size> _sizeRepository;

        public SizeService(IGenericRepository<Size> sizeRepository)
        {
            _sizeRepository = sizeRepository;
        }

        public async Task<Guid> AddSize(Size size)
        {
            return await _sizeRepository.Add(size);
        }

        public async Task<bool> DeleteByIdSize(Guid id)
        {
            return await _sizeRepository.DeleteById(id);
        }

        public async Task<IEnumerable<Size>> GetAllSizes()
        {
            return await _sizeRepository.GetAll();
        }

        public async Task<Size> GetByIdSize(Guid id)
        {
            return await _sizeRepository.GetById(id);
        }

        public async Task<bool> UpdateSize(Size size)
        {
            return await _sizeRepository.Update(size);
        }
    }
}
