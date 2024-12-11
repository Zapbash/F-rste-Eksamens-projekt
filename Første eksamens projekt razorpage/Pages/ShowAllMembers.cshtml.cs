using Første_Eksamens_projekt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Første_eksamens_projekt_razorpage.Pages
{
    public class ShowAllMembersModel : PageModel
    {
        public Member member;
        private MemberRepo _MemberRepo;

        public ShowAllMembersModel(MemberRepo memberRepo)
        {
            _MemberRepo = memberRepo;
        }

        public List<Member>? members { get; private set; } = new List<Member>();
        public void OnGet()
        {
            members = _MemberRepo.GetAllMembers();

		}
	}
}