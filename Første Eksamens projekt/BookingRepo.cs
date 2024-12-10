using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    public class BookingRepo
    {
        public List<Booking> bookingList = new List<Booking>();// lister der indeholder alle booking obejekter i repository

        public void AddBooking(Booking bookings)// Tilføjer en booking til repository, hvis den ikke findes 
        {
            if (!bookingList.Contains(bookings)) { bookingList.Add(bookings); } // Tjekker om booking allerede findes og hvis den ikke findes så tilføjer den en booking
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
        public Booking UpdateBookingRepo(Booking UpdatedBooking) // Opdatere en eksiterende booking i repository
        {
            Booking NewBooking = GetBooking(UpdatedBooking.Id); // Finder den booking som skal opdateres
            if (NewBooking != null)
            { // Opdatere den eksiterende booking med de her nye værdier
                NewBooking.Member = UpdatedBooking.Member;
                NewBooking.Period = UpdatedBooking.Period;
                NewBooking.Boat = UpdatedBooking.Boat;
                NewBooking.Price = UpdatedBooking.Price;
                return NewBooking; // Returnere den opdateret booking 
            }
            return null!; // Returnere null, hvis bookingen ikke findes 
        }
    }
}
