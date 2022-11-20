using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAllClients();
        Task<Client> GetByIdClient(Guid id);
        Task<bool> DeleteByIdClient(Guid id);
        Task<bool> UpdateClient(Client client);
        Task<Guid> AddClient(Client client);
    }
}
