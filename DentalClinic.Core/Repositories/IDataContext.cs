using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentalClinic.Core.Entities;

namespace DentalClinic.Core.Repositories
{
    public interface IDataContext
    {
        List<Client> Clients { get; set; }
        List<Room> Rooms { get; set; }
        List<Worker> Workers { get; set; }
        List<Appointment> Appointments { get; set; }
    }
}
