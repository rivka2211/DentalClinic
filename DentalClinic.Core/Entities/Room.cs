using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Core.Entities
{
    public enum SuitableEnum
    {
        All, Dentist, OrtodentOrthodontist
    }

    public class Room
    {
        public int Floor { get; set; }
        public int Number { get; set; }
        [Key]
        public int Id { get; set; }
        public SuitableEnum Suitable { get; set; }

        public Room()
        {

        }

        public Room(int floor, int number, SuitableEnum suitable)
        {
            Floor = floor;
            Number = number;
            Suitable = suitable;
        }

        public override string? ToString()
        {
            return $"room number:{Number}, floor:{Floor}, suitable:{Suitable} \n";
        }

        public override bool Equals(object? obj)
        {
            return obj is Room room &&
                   Floor == room.Floor &&
                   Number == room.Number &&
                   Id == room.Id &&
                   Suitable == room.Suitable;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Floor, Number, Id, Suitable);
        }
    }
}
