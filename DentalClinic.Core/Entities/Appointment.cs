using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Core.Entities
{
    public class Appointment
    {
        //private static int key = 100;
        [Key]
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public Worker Worker { get; set; }
        public Client Client { get; set; }
        public Room Room { get; set; }
        public int Duration { get; set; }
        public bool FirstAid { get; set; }

        public Appointment()
        {

        }

        public Appointment(int id, DateOnly date, TimeOnly time, Worker worker, Client client, Room room, int duration = 30, bool firstAid = false)
        {
            Id = id;
            Date = date;
            Time = time;
            Room = room;
            Worker = worker;
            Client = client;
            Duration = duration;
            FirstAid = firstAid;
        }

        public override bool Equals(object? obj)
        {
            return obj is Appointment appointment &&
                   Date.Equals(appointment.Date) &&
                   Time.Equals(appointment.Time) &&
                   EqualityComparer<Worker>.Default.Equals(Worker, appointment.Worker) &&
                   EqualityComparer<Client>.Default.Equals(Client, appointment.Client) &&
                   EqualityComparer<Room>.Default.Equals(Room, appointment.Room) &&
                   Duration == appointment.Duration &&
                   FirstAid == appointment.FirstAid;
        }

    }
}
