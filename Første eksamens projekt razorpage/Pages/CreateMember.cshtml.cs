using Første_Eksamens_projekt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Første_eksamens_projekt_razorpage.Pages
{
    public class CreateMemberModel : PageModel
    {
       
        private MemberRepo _MemberRepo;

        public CreateMemberModel(MemberRepo memberRepo)
        {
            _MemberRepo = memberRepo;
            
        }

        [BindProperty]
        public Member member { get; set; } = new Member();
        


        public List<Member>? members { get; private set; }

		public IActionResult OnGet()
		{
			return Page();
		}

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_MemberRepo.AddMember(member);

			return RedirectToPage("/ShowAllMembers");
		}
	}
}
