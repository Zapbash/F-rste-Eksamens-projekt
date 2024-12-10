using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    public class MemberRepo
    {
         
        public List<Member> memberList = new List<Member>();
       
        public void AddMember(Member members) // tilføjer en member til repository
        {
            if (!memberList.Contains(members)) memberList.Add(members); // Tjekker om member er findes i listen og derefter tilføjer den hvis den ik findes
        }
        
        public Member RemoveMember(int id) // Fjener en member fra repository via id
        {
            Member members = GetMember(id);// Finder en member via id
            if (memberList.Remove(members)) // Hvis member findes så fjernes member fra listen
            {
                return members; // Returnere den fjernede member
            }
            return null!;// Returnere null hvis den ikke findes 
        } 
        // Read listen af alle members
        public List<Member> GetAllMembers()
        {
            return memberList;// Returnere memberlisten 
        }

        //Find den enkelte member med id ?
        public Member GetMember(int id)
        {
            foreach (Member members in memberList) //brug en foreach som løber listen igennem for at finde member med id ?
            {
                if (members.Id == id) return members; // Tjekker om id'et findes og den returnere derefter hvis den findes
                
            }
            return null!; // Returner null, hvis medlemmet ikke findes
        }
         
        // UpdateMember 
        public Member UpdateMemberRepo(Member UpdatedMember)
        {
            Member NewMember = GetMember(UpdatedMember.Id); // brug getmember metoden til at finde memberen
            if (NewMember != null) // hvis member findes opdater vi dette instansfelter
            {
                NewMember.Name = UpdatedMember.Name; 
                NewMember.Email = UpdatedMember.Email;
                NewMember.PhoneNumber = UpdatedMember.PhoneNumber;
                NewMember.BirthDay = UpdatedMember.BirthDay;
                return NewMember;  // Returnere den opdateret member 
            }
            return null!; // Returnere null, hvis den member ikke findes 
        }
    } 
}