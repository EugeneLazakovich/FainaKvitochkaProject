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
    public class SaleService : ISaleService
    {
        private readonly IGenericRepository<Sale> _saleRepository;

        public SaleService(IGenericRepository<Sale> saleRepository)
        {
            _saleRepository = saleRepository;
        }

        public async Task<Guid> AddSale(Sale sale)
        {
            return await _saleRepository.Add(sale);
        }

        public async Task<bool> DeleteByIdSale(Guid id)
        {
            return await _saleRepository.DeleteById(id);
        }

        public async Task<IEnumerable<Sale>> GetAllSales()
        {
            return await _saleRepository.GetAll();
        }

        public async Task<Sale> GetByIdSale(Guid id)
        {
            return await _saleRepository.GetById(id);
        }

        public async Task<bool> UpdateSale(Sale sale)
        {
            return await _saleRepository.Update(sale);
        }
    }
}
