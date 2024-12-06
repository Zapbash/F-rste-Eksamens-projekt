using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    public class Admin : Person
    {
        public Admin(int id, string name, int phoneNumber, string email, DateTime birthDay) :base (id,name,phoneNumber, email,birthDay)
        {


        }
        public override string ToString()
        {
            return $"{Id} {Name} {PhoneNumber} {Email} {BirthDay} ";
        }
    }
}
