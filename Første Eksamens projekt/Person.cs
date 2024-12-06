using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }

        public Person (int id, string name, int phoneNumber, string email, DateTime birthDay)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            BirthDay = birthDay;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {PhoneNumber} {Email} {BirthDay}";
        }
    }
}
