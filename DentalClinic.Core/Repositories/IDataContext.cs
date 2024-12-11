using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentalClinic.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DentalClinic.Core.Repositories
{
    public interface IDataContext
    {
        DbSet<Client> Clients { get; set; }
        DbSet<Room> Rooms { get; set; }
        DbSet<Worker> Workers { get; set; }
        DbSet<Appointment> Appointments { get; set; }

        
    }
}
