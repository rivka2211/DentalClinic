using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
using DentalClinic.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Service
{
    public class ClientService:IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public DbSet<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public IEnumerable<Client> GetById(int id)
        {
            return _clientRepository.GetById(id);
        }
        public IEnumerable<Client> GetByMedicalInsurance(MedicalInsuranceEnum medicalInsurance)
        {
            return _clientRepository.GetByMedicalInsurance(medicalInsurance);
        }
        public Task<bool> Post(Client client)
        {
            return _clientRepository.Post(client);
        }
        public Task<bool> Put(int Id, Client client)
        {
            return _clientRepository.Put(Id, client);
        }
        public Task<bool> Delete(int id)
        {
            return _clientRepository.Delete(id);
        }
    }
}
