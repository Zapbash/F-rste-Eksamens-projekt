using Første_Eksamens_projekt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Første_eksamens_projekt_razorpage.Pages
{
    public class ShowAllBookingsModel : PageModel
    {
        public Booking booking;
        private BookingRepo _BookingRepo;

        public ShowAllBookingsModel(BookingRepo bookingRepo)
        {
            _BookingRepo = bookingRepo;
        }

        public List<Booking>? BookingList { get; private set; } = new List<Booking>();
        public void OnGet()
        {
            BookingList = _BookingRepo.GetAllBookings();

        }
    }
}
