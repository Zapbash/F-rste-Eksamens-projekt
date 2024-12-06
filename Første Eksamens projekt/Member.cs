using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    public class Member : Person
    {
      

       

        public Member(int id, string name, int phoneNumber, string email, DateTime birthday) :base (id, name, phoneNumber, email, birthday)
        {
          
            
        }


        public override string? ToString()
        {
            return $"{Id} {Name}{PhoneNumber} {Email} {BirthDay}";
        }
    }
}
