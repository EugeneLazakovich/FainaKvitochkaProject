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
    public class ItemSaleService : IItemSaleService
    {
        private readonly IGenericRepository<ItemSale> _itemSaleRepository;

        public ItemSaleService(IGenericRepository<ItemSale> itemSaleRepository)
        {
            _itemSaleRepository = itemSaleRepository;
        }

        public async Task<Guid> AddItemSale(ItemSale itemSale)
        {
            return await _itemSaleRepository.Add(itemSale);
        }

        public async Task<bool> DeleteByIdItemSale(Guid id)
        {
            return await _itemSaleRepository.DeleteById(id);
        }

        public async Task<IEnumerable<ItemSale>> GetAllItemSales()
        {
            return await _itemSaleRepository.GetAll();
        }

        public async Task<ItemSale> GetByIdItemSale(Guid id)
        {
            return await _itemSaleRepository.GetById(id);
        }

        public async Task<bool> UpdateItemSale(ItemSale itemSale)
        {
            return await _itemSaleRepository.Update(itemSale);
        }
    }
}
