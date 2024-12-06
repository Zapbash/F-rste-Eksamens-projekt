using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    public class BookingRepo
    {
        public List<Booking> bookingList = new List<Booking>();

        public void AddBooking(Booking bookings)
        {
            if (!bookingList.Contains(bookings)) { bookingList.Add(bookings); }
        }
        public Booking RemoveBooking(int id)
        {
            Booking bookings = GetBooking(id);
            if (bookingList.Remove(bookings))
            {
                return bookings;
            }
            return null!;
        }
        public Booking GetBooking(int id)
        {
            foreach (Booking bookings in bookingList)
            {
                if (bookings.Id == id) return bookings;
            }
            return null!;

        }
        public List<Booking> GetAllBookings()
        {
            return bookingList;
        }
        public Booking UpdateBookingRepo(Booking UpdatedBooking)
        {
            Booking NewBooking = GetBooking(UpdatedBooking.Id);
            if (NewBooking != null)
            {
                NewBooking.Member = UpdatedBooking.Member;
                NewBooking.Period = UpdatedBooking.Period;
                NewBooking.Boat = UpdatedBooking.Boat;
                NewBooking.Price = UpdatedBooking.Price;
                return NewBooking;
            }
            return null!;
        }
    }
}
