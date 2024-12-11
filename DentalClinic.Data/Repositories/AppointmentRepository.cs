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
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly IDataContext _context;

        public AppointmentRepository(IDataContext context)
        {
            _context = context;
        }

        public DbSet<Appointment> GetAll()
        {
            return _context.Appointments;
        }
        public IEnumerable<Appointment> GetByid(int id)
        {
            Appointment a = _context.Appointments.ToList().Find(c => c.Id == id);
            yield return a;
        }
        public IEnumerable<Appointment> GetByClient(Client client)
        {
            return _context.Appointments.Where(a => a.Client == client).ToList();

        }
        public IEnumerable<Appointment> GetByWorker(Worker worker)
        {
            return _context.Appointments.Where(a => a.Worker == worker).ToList();

        }
        public async Task<bool> Post(Appointment ap)
        {
            try
            {
                //_context.Appointments.Add(new Appointment(ap.Date, ap.Time, ap.Room, ap.Client, ap.Room, ap.Duration, ap.FirstAid));
                await _context.Appointments.AddAsync(ap); // הוספת המינוי
                return true;
            }
            catch
            {
                return false;
            }

        }
        public async Task<bool> Put(int id, Appointment value)
        {
            try
            {
                var ap = _context.Appointments.Where(c => c.Id == id).First();
                if (ap == null)
                    return false;
                if (ap.Equals(value))
                    return true;
                ap.Date = value.Date;
                ap.Time = value.Time;
                ap.Room = value.Room;
                ap.Worker = value.Worker;
                ap.Client = value.Client;
                ap.Duration = value.Duration;
                ap.FirstAid = value.FirstAid;
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
                var ap = _context.Appointments.Where(c => c.Id == id).First();
                _context.Appointments.Remove(ap);
                return true;
            }
            catch
            {
                return false;
            }

        }


    }
}
