using DentalClinic.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Core.Services
{
    public interface IClientService
    {
        DbSet<Client> GetAll();

        IEnumerable<Client> GetById(int id);
        IEnumerable<Client> GetByMedicalInsurance(MedicalInsuranceEnum medicalInsurance);
        Task<bool> Post(Client client);
        Task<bool> Put(int Id, Client client);
        Task<bool> Delete(int id);
    }
}
