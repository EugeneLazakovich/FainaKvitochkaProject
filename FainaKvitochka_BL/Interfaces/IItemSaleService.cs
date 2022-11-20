using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface IItemSaleService
    {
        Task<IEnumerable<ItemSale>> GetAllItemSales();
        Task<ItemSale> GetByIdItemSale(Guid id);
        Task<bool> DeleteByIdItemSale(Guid id);
        Task<bool> UpdateItemSale(ItemSale itemSale);
        Task<Guid> AddItemSale(ItemSale itemSale);
    }
}
