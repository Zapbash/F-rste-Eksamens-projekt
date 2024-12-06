using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    public interface IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public interface IPerson(int id)
    }

}
