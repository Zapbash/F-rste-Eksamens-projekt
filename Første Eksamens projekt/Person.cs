using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    public abstract class Person
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }

        public Person (int id, string name, int phoneNumber, string email, DateTime birthDay)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            BirthDay = birthDay;
        }

        public Person()
        {
        }

        public override string ToString()
        {
            return $"{Id} {Name} {PhoneNumber} {Email} {BirthDay}";
        }
    }
}
