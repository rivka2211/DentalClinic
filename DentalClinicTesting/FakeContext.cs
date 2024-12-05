using DentalClinic.Core.Entities;
using DentalClinic.Core.Repositories;

namespace DentalTest
{
    public class FakeContext : IDataContext
    {
        public List<Client> Clients { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Worker> Workers { get; set; }
        public List<Appointment> Appointments { get; set; }

        public FakeContext()
        {
            Clients = new List<Client>();
            Rooms = new List<Room>();
            Workers = new List<Worker>();
            Appointments = new List<Appointment>();

            DateOnly dd = new DateOnly(2000, 10, 23);
            Client c1 = new Client(123, "rivki", "bb", MedicalInsuranceEnum.Klalit, dd);
            Clients.Add(c1);
            Appointment a1 = new Appointment(dd, new TimeOnly(), new Worker(), c1, new Room(), 20);
            Appointments.Add(a1);
        }
    }
}
