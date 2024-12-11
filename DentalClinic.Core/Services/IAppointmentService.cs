using DentalClinic.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Core.Services
{
    public interface IAppointmentService
    {
        DbSet<Appointment> GetAll();
        IEnumerable<Appointment> GetByid(int id);
        IEnumerable<Appointment> GetByClient(Client client);
        IEnumerable<Appointment> GetByWorker(Worker worker);
        Task<bool> Post(Appointment appointment);
        Task<bool> Put(int id, Appointment appointment);
        Task<bool> Delete(int id);
    }

}
