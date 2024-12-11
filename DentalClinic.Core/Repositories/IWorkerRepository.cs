using DentalClinic.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Core.Repositories
{
    public interface IWorkerRepository
    {
        DbSet<Worker> GetAll();

        IEnumerable<Worker> GetById(int Id);
        IEnumerable<Worker> GetByProfession(ProfessionsEnum profession);
        Task<bool> Post(Worker Worker);
        Task<bool> Put(int Id, Worker Worker);
        Task<bool> Delete(int Id);

    }
}
