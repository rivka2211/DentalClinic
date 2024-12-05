using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DentalClinic.Data
{
    public class DataContext :DbContext, IDataContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public DataContext()
        {
            //Clients = new List<Client>();
            //Rooms = new List<Room>();
            //Workers = new List<Worker>();
            //Appointments = new List<Appointment>();
            ////איתחול
            //DateOnly dd = new DateOnly(2000, 10, 23);
            //Client c1 = new Client(123, "rivki", "bb", MedicalInsuranceEnum.Klalit, dd);
            //Client c2 = new Client(456, "rty", "bb", MedicalInsuranceEnum.Macabi, dd);
            //Clients.Add(c1);
            //Clients.Add(c2);
            //Worker w1 = new Worker(111, "atar", ProfessionsEnum.Orthodontist, "pt", 5000);
            //Appointment a1 = new Appointment(dd, new TimeOnly(), w1, c1, new Room(), 20);
            //Appointment a2 = new Appointment(dd, new TimeOnly(), new Worker(), c2, new Room(), 50);
            //Appointments.Add(a1);
            //Appointments.Add(a2);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=__DentalClinic__DB");
        }
    }
}
