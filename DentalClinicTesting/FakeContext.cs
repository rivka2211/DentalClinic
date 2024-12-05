using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DentalTest
{
    public class FakeContext : IDataContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public FakeContext()
        {
            //Clients = new DbSet<Client>();
            //Rooms = new DbSet<Room>();
            //Workers = new DbSet<Worker>();
            //Appointments = new DbSet<Appointment>();

            //DateOnly dd = new DateOnly(2000, 10, 23);
            //Client c1 = new Client(123, "rivki", "bb", MedicalInsuranceEnum.Klalit, dd);
            //Clients.Add(c1);
            //Appointment a1 = new Appointment(dd, new TimeOnly(), new Worker(), c1, new Room(), 20);
            //Appointments.Add(a1);
        }
    }
}
