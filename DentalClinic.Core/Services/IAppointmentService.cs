using DentalClinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Core.Services
{
    public interface IAppointmentService
    {
        List<Appointment> GetAll();
        IEnumerable<Appointment> GetByCode(int code);
        IEnumerable<Appointment> GetByClient(Client client);
      IEnumerable<Appointment> GetByWorker(Worker worker);
      /*IEnumerable<string> Post(Appointment appointment);
      IEnumerable<string> Put(int code, Appointment appointment);
      IEnumerable<string> Delete(int code);*/
    }

}
