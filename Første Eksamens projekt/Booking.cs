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


        public Booking(int id, Member member, Boat boat, DateTime startDate, DateTime endDate)
        {
            Id = id;
            Member = member;
            Boat= boat;
            StartDate = startDate;
            EndDate = endDate;
            TotalPrice = CalculateTotalPrice();
        }

        public Booking()
        {
            
        }

        /// <summary>
        /// Har med hensigt at udregne den totalepris ud fra mængde af dage * bådens pris
        /// </summary>
        
        public double CalculateTotalPrice()
        {
            // Calculate the number of days
            int days = (EndDate - StartDate).Days;

            // Ensure the number of days is at least 1
            if (days <= 0)
            {
                throw new ArgumentException("Booking period must be at least one day.");
            }

            // Calculate the total price
            double totalPrice = days * Boat.Price;

            return totalPrice;
        }

        public override string ToString()
        {
            return $"{Id} {Member} {Boat} {StartDate} {EndDate} {TotalPrice}";
        }


    }
}
