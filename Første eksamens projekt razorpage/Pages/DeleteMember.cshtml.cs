using Første_Eksamens_projekt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace Første_eksamens_projekt_razorpage.Pages
{
	public class DeleteMemberModel : PageModel
	{
		private readonly MemberRepo _memberRepo;


		public DeleteMemberModel(MemberRepo memberRepo)
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
			Member deletedMember = _memberRepo.RemoveMember(member.Id);
			if (deletedMember == null)
				return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

			return RedirectToPage("/ShowAllMembers");
		}

	}
}