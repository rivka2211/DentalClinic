using DentalClinic.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Core.Repositories
{
    public interface IAppointmentRepository
    {
        DbSet<Appointment> GetAll();

        IEnumerable<Appointment> GetByCode(int code);
        IEnumerable<Appointment> GetByClient(Client client);
        IEnumerable<Appointment> GetByWorker(Worker worker);
        /* IEnumerable<string> Post(Appointment appointment);
         IEnumerable<string> Put(int code,Appointment appointment);
         IEnumerable<string> Delete(int code);*/

    }
}
