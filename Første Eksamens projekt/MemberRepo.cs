using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    internal class MemberRepo
    {
        // Liste af alle members 
        public List<Member> Members = new List<Member>();
        // Add en member til listen members
        public void addMember(Member member) { Members.Add(member); }
        // Remove en member fra listen members
        public void removeMember(Member member)
        {
            Members.Remove(member);
        } 
        // Read listen af alle members
        public List<Member> GetAllMembers()
        {
            return Members;
        }

        //Find den enkelte member med id ?
        public Member GetMember(int id)
        {
            foreach (var member in Members) //brug en foreach som løber listen igennem for at finde member med id ?
            {
                if (member.id == id)
                {
                    return member;
                }
            }
            return null; // Returner null, hvis medlemmet ikke findes
        }
         
        // UpdateMember 
        public Member UpdateMember(int id, Member updated)
        {
            Member member = GetMember(id); // brug getmember metoden til at finde memberen
            if (member != null) // hvis member findes opdater vi dette instansfelter
            {
                member.Name = updated.Name; 
                member.Email = updated.Email;
                member.Birthday = updated.Birthday; 
                return member; // Returner det du har skrevet
            }
            return null; // Returner null, hvis member ikke findes
        }
    } 
}