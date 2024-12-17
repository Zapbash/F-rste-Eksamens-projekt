using Første_Eksamens_projekt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Første_eksamens_projekt_razorpage.Pages
{
    public class ShowBoatsModel : PageModel
    {
        
        private  BoatRepo _boatRepo;

        public ShowBoatsModel(BoatRepo boatRepo)
        {
            _boatRepo = boatRepo;
        }

        public List<Boat> Boats { get; private set; }

        public void OnGet()
        {
            Boats = _boatRepo.GetAllBoat();
            


        }
    }
}
