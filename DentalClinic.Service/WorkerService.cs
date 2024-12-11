using DentalClinic.Core;
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
    public class WorkerService : IWorkerService
    {
        private readonly IWorkerRepository _workerRepository;
        public WorkerService(IWorkerRepository workerRepository)
        {
            _workerRepository = workerRepository;
        }

        public DbSet<Worker> GetAll()
        {
            return _workerRepository.GetAll();
        }

        public IEnumerable<Worker> GetById(int Id)
        {
            return _workerRepository.GetById(Id);
        }
        public IEnumerable<Worker> GetByProfession(ProfessionsEnum profession)
        {
            return _workerRepository.GetByProfession(profession);
        }
        public Task<bool> Post(Worker worker)
        {
            return _workerRepository.Post(worker);
        }
        public Task<bool> Put(int Id, Worker worker)
        {
            return _workerRepository.Put(Id, worker);
        }
        public Task<bool> Delete(int Id)
        {
            return _workerRepository.Delete(Id);
        }
    }
}
