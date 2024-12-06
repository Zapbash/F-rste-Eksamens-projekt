using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    public class Booking
    {
        public int Id {  get; set; }
        public Member Member { get; set; }
        public DateTime Period { get; set; }

        public Boat Boat { get; set; }
        public double Price { get; set; }

        public Booking(int id, Member member, DateTime period, Boat boat, double price)
        {
            Id = id;
            Member = member;
            this.Period = period;
            Boat = boat;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Id} {Member} {Period} {Boat} {Price}";
        }
    }
}
