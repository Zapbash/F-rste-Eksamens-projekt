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
        public int MemberId { get; set; }  
        public int BoatId { get; set; }
        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TotalPrice { get; set; }


        public Booking(int id, Member memberId, Boat boatId, DateTime startDate, DateTime endDate, double totalPrice)
        {
            Id = id;
            MemberId = memberId.Id;
            BoatId = boatId.Id;
            StartDate = startDate;
            EndDate = endDate;
            TotalPrice = totalPrice;
        }

        public Booking()
        {
            
        }
        public override string ToString()
        {
            return $"{Id} {MemberId} {BoatId} {StartDate} {EndDate} {TotalPrice}";
        }
    }
}
