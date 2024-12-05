using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Data.Repositories
{
    public class WorkerRepository:IWorkerRepository
    {
        private readonly IDataContext _context;

        public WorkerRepository(IDataContext context)
        {
            _context = context;
        }
        public List<Worker> GetAll()
        {
            return _context.Workers.ToList();
        }
    }
}
