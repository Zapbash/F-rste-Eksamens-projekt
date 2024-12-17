using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Første_Eksamens_projekt;

namespace Første_Eksamens_projekt
{
    public class BookingRepo
    {
        
        private int _currentBookingId = 1;
        public BookingRepo()
        {

        }

        public List<Booking> bookingList = new List<Booking>();// lister der indeholder alle booking obejekter i repository

        public void AddBooking(Booking bookings)// Tilføjer en booking til repository, hvis den ikke findes 
        {
            if (!bookingList.Contains(bookings)) { bookingList.Add(bookings); } // Tjekker om booking allerede findes og hvis den ikke findes så tilføjer den en booking
            bookings.Id = _currentBookingId++; //Gør bookingId incremented
        }
        public Booking RemoveBooking(int id)// Fjerner en booking  fra repository baseret på id 
        {
            Booking bookings = GetBooking(id);// Finder booking via id 
            if (bookingList.Remove(bookings))// Hvis booking findes så fjernes den fra listen 
            {
                return bookings;// Returnere den fjernede booking 
            }
            return null!;// Returnere null hvis den ikke findes 
        }
        public Booking GetBooking(int id)// Finder en booking via id
        {
            foreach (Booking bookings in bookingList) // Gennemgår listen af bookinger
            {
                if (bookings.Id == id) return bookings;// Sammenligner alle booking id med den indtastet id  og returnere dermed booking hvis den findes 
            }
            return null!;// returnere null hvis  booking ke findes

        }
        public List<Booking> GetAllBookings() // Returnere hele booking listen i repository 
        {
            return bookingList;// returnere hele booking listen 
        }

        // Calculate total price
        public double CalculateTotalPrice(Booking booking, Boat boat)
        {
            // Calculate the number of days
            int days = (booking.EndDate - booking.StartDate).Days;

            // Ensure the number of days is at least 1
            if (days <= 0)
            {
                throw new ArgumentException("Booking period must be at least one day.");
            }

            // Calculate the total price
            double totalPrice = days * boat.Price;

            return totalPrice;
        }
    



        public List<Booking> Searchbooking(int memberId) // man kan søge ude fra members id
        {
            List<Booking> bookingsResult = new List<Booking>();
            foreach (Booking bookings in bookingList)
            {
                if (bookings.MemberId == memberId) bookingsResult.Add(bookings);
            }
            return bookingsResult;
                
        }
        public Booking UpdateBookingRepo(Booking UpdatedBooking) // Opdatere en eksiterende booking i repository
        {
            Booking NewBooking = GetBooking(UpdatedBooking.Id); // Finder den booking som skal opdateres
            if (NewBooking != null)
            { // Opdatere den eksiterende booking med de her nye værdier
                NewBooking.MemberId = UpdatedBooking.MemberId;
             
                NewBooking.BoatId = UpdatedBooking.BoatId;
                NewBooking.StartDate = UpdatedBooking.StartDate;
                NewBooking.EndDate = UpdatedBooking.EndDate;
                NewBooking.TotalPrice = UpdatedBooking.TotalPrice;
                return NewBooking; // Returnere den opdateret booking 
            }
            return null!; // Returnere null, hvis bookingen ikke findes 
        }

        
    }
    
}
