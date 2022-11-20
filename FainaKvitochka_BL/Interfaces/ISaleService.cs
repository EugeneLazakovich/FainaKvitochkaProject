using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface ISaleService
    {
        Task<IEnumerable<Sale>> GetAllSales();
        Task<Sale> GetByIdSale(Guid id);
        Task<bool> DeleteByIdSale(Guid id);
        Task<bool> UpdateSale(Sale sale);
        Task<Guid> AddSale(Sale sale);
    }
}
