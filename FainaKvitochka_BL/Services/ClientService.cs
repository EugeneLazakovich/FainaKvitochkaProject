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
    public class ClientService : IClientService
    {
        private readonly IGenericRepository<Client> _clientRepository;

        public ClientService(IGenericRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Guid> AddClient(Client client)
        {
            return await _clientRepository.Add(client);
        }

        public async Task<bool> DeleteByIdClient(Guid id)
        {
            return await _clientRepository.DeleteById(id);
        }

        public async Task<IEnumerable<Client>> GetAllClients()
        {
            return await _clientRepository.GetAll();
        }

        public async Task<Client> GetByIdClient(Guid id)
        {
            return await _clientRepository.GetById(id);
        }

        public async Task<bool> UpdateClient(Client client)
        {
            return await _clientRepository.Update(client);
        }
    }
}
