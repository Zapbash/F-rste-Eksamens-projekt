using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    internal class Member
    {
      

        public int id { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }
        public DateTime Birthday { get; set; } 

        public Member(int id, string name, string email, DateTime birthday)
        {
            this.id = id;
            Name = name;
            Email = email;
            this.Birthday = birthday;
        }


        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
