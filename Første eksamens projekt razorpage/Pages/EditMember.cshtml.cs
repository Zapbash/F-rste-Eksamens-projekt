using Første_Eksamens_projekt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Første_eksamens_projekt_razorpage.Pages
{
    public class EditMemberModel : PageModel
    {
        private readonly MemberRepo _memberRepo;

        public EditMemberModel(MemberRepo memberRepo)
        {
            _memberRepo = memberRepo;
        }

        [BindProperty]
        public Member member { get; set; }

        public IActionResult OnGet(int id)
        {
            member = _memberRepo.GetMember(id);
            if (member == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _memberRepo.UpdateMemberRepo(member);
            return RedirectToPage("/ShowAllMembers");
        }
    }
}
    
