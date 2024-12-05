namespace DentalClinic.Core.Entities
{
    public enum MedicalInsuranceEnum
    {
        Macabi, Meochedet, Klalit, Leumit
    }
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public MedicalInsuranceEnum MedicalInsurance { get; set; }
        public DateOnly BirthDate { get; set; }

        public Client()
        {

        }

        public Client(int id, string name, string address, MedicalInsuranceEnum medicalInsurance, DateOnly birthDate)
        {
            Id = id;
            Name = name;
            Address = address;
            MedicalInsurance = medicalInsurance;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"client id:{Id}, name:{Name}, address:{Address}, medicalInsurance:{MedicalInsurance}, birthDate:{BirthDate}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Client client &&
                   Id == client.Id &&
                   Name == client.Name &&
                   Address == client.Address &&
                   MedicalInsurance == client.MedicalInsurance &&
                   BirthDate.Equals(client.BirthDate);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Address, MedicalInsurance, BirthDate);
        }
    }
}
