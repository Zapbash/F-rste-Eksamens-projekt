using Første_Eksamens_projekt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Første_eksamens_projekt_razorpage.Pages
{
    public class BookingModel : PageModel
    {
        private BookingRepo _bookingRepo;
        private MemberRepo _memberRepo;
        private BoatRepo _boatRepo;
        


        [BindProperty]
        public Booking booking { get; set; }

        [BindProperty]
        public int MemberId { get; set; }
        [BindProperty]
        public int BoatId { get; set; }

        [BindProperty]
        public DateTime StartDate { get; set; }

        [BindProperty]
        public DateTime EndDate { get; set; }


        public List<Member> Members { get; set; }
        public List<Boat> Boats { get; set; }
        public Boat SelectedBoatId { get; set; }
        public Member SelectMemberId { get; set; }
        public double TotalPrice { get; set; }
        public string Message { get; private set; }


        public BookingModel(BookingRepo bookingRepo, MemberRepo memberRepo, BoatRepo boatRepo)
        {
            _bookingRepo = bookingRepo;
            _memberRepo = memberRepo;
            _boatRepo = boatRepo;
        }


        public IActionResult OnGet(int boatId)
        {

            // Load the boats and members for the dropdowns
            Boats = _boatRepo.GetAllBoat();
            Members = _memberRepo.GetAllMembers();

            return Page();
        }

        public List<Booking>? BookingList { get; private set; } = new List<Booking>();
        public IActionResult OnPost(int memberId, int boatId, DateTime startDate, DateTime endDate)
        {
            if (ModelState.IsValid)
            {
                // Retrieve the selected boat and member from the repositories
                var boat = _boatRepo.GetBoat(boatId);  // Get the boat object by ID
                var member = _memberRepo.GetMember(memberId); // Get the member object by ID

                if (boat == null || member == null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid boat or member selection.");
                    return Page();
                }

                // Create a new booking instance
                var booking = new Booking
                {
                    MemberId = memberId,  // Store the MemberId
                    BoatId = boatId,      // Store the BoatId
                    StartDate = startDate,
                    EndDate = endDate
                };

                try
                {
                    // Calculate the total price using the repository method
                    TotalPrice = _bookingRepo.CalculateTotalPrice(booking, boat);

                    // Save the booking with the calculated price
                    booking.TotalPrice = TotalPrice;
                    _bookingRepo.AddBooking(booking);  // Add the actual booking object

                    // Redirect to the ShowAllBookings page
                    return RedirectToPage("ShowAllBookings");
                }
                catch (ArgumentException ex)
                {
                    // Display an error message if the booking dates are invalid
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }

            // Reload the dropdown lists in case of errors
            Boats = _boatRepo.GetAllBoat();
            Members = _memberRepo.GetAllMembers();
            return Page();
        }

    }
}