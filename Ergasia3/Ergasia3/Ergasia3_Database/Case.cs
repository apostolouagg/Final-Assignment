using System.Collections.Generic;

namespace Ergasia3_Database
{
    public class Case
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string BirthDay { get; set; }
        public string Address { get; set; }
        public string TimeOfCase { get; set; }

        public List<UnderlyingDisease> UnderlyingDiseases { get; set; } = new List<UnderlyingDisease>();

        public Case()
        {

        }

        public Case(int id, string fullName, string email, string phoneNumber, string gender, string birthDay, string address, string timeOfCase, List<UnderlyingDisease> underlyingDiseases)
        {
            ID = id;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Gender = gender;
            BirthDay = birthDay;
            Address = address;
            TimeOfCase = timeOfCase;
            UnderlyingDiseases = underlyingDiseases;
        }
    }
}
