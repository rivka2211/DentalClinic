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
    public class WorkerRepository:IWorkerRepository
    {
        private readonly IDataContext _context;

        public WorkerRepository(IDataContext context)
        {
            _context = context;
        }

        public DbSet<Worker> GetAll()
        {
            return _context.Workers;
        }

        public IEnumerable<Worker> GetById(int id)
        {
            Worker w = _context.Workers.ToList().Find(c => c.Id == id);
            yield return w;
        }
        public IEnumerable<Worker> GetByProfession(ProfessionsEnum profession)
        {
            return _context.Workers.Where(a => a.Profession==profession).ToList();
        }
       
        public async Task<bool> Post(Worker worker)
        {
            try
            {
                await _context.Workers.AddAsync(worker); // הוספת המינוי
               // await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public async Task<bool> Put(int id, Worker value)
        {
            try
            {
                var worker = _context.Workers.Where(c => c.Id == id).First();
                if (worker == null)
                    return false;
                if (worker.Equals(value))
                    return true;
                worker.Profession = value.Profession;
                worker.Address = value.Address;
                worker.Name = value.Name;
                worker.Salary = value.Salary;
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
                var ap = _context.Workers.Where(c => c.Id == id).First();
                _context.Workers.Remove(ap);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
