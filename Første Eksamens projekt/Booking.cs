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
        public Boat Boat { get; set; }
        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TotalPrice { get; set; }


        public Booking(int id, Member member, Boat boat, DateTime startDate, DateTime endDate, double totalPrice)
        {
            Id = id;
            Member = member;
            Boat= boat;
            StartDate = startDate;
            EndDate = endDate;
            TotalPrice = totalPrice;
        }

        public Booking()
        {
            
        }
        public override string ToString()
        {
            return $"{Id} {Member} {Boat} {StartDate} {EndDate} {TotalPrice}";
        }
    }
}
