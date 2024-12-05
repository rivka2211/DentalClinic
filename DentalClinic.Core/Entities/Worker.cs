namespace DentalClinic.Core.Entities
{
    public enum ProfessionsEnum
    {
        Dentist, Secretery, Orthodontist, Assistant
    }
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProfessionsEnum Profession { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }

        public Worker()
        {

        }

        public Worker(int id, string name, ProfessionsEnum profession = ProfessionsEnum.Dentist, string address = "", double salary = 500)
        {
            Id = id;
            Name = name;
            Profession = profession;
            Address = address;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"worker: id={Id}, name={Name}, profession={Profession} \n";
        }

        public override bool Equals(object? obj)
        {
            return obj is Worker worker &&
                   Id == worker.Id &&
                   Name == worker.Name &&
                   Profession == worker.Profession &&
                   Address == worker.Address &&
                   Salary == worker.Salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Profession, Address, Salary);
        }
    }
}
