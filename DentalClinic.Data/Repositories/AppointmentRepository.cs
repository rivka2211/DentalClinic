using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
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
        public List<Appointment> GetAll()
        {
            return _context.Appointments;
        }
        public IEnumerable<Appointment> GetByCode(int code)
        {
            Appointment a = _context.Appointments.Find(c => c.Code == code);
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
    }
}
