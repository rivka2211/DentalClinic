using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IDataContext _context;

        public ClientRepository(IDataContext context)
        {
            _context = context;
        }
        public DbSet<Client> GetAll()
        {
            return _context.Clients;
        }
        public IEnumerable<Client> GetById(int id)
        {
            Client c = _context.Clients.ToList().Find(c => c.Id == id);
            yield return c;
        }
        public IEnumerable<Client> GetByMedicalInsurance(MedicalInsuranceEnum medicalInsurance)
        {
            return _context.Clients.Where(c => c.MedicalInsurance == medicalInsurance);
        }
        public async Task<bool> Post(Client client)
        {
            try
            {
                await _context.Clients.AddAsync(client); // הוספת המינוי
                                                         // await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public async Task<bool> Put(int id, Client value)
        {
            try
            {
                var Client = _context.Clients.Where(c => c.Id == id).First();
                if (Client == null)
                    return false;
                if (Client.Equals(value))
                    return true;
                Client.MedicalInsurance = value.MedicalInsurance;
                Client.Address = value.Address;
                Client.Name = value.Name;
                Client.BirthDate = value.BirthDate;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> Delete(int id)
        {
            try
            {
                var ap = _context.Clients.Where(c => c.Id == id).First();
                _context.Clients.Remove(ap);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
