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
       
        public void AddMember(Member members)
        {
            if (!memberList.Contains(members)) memberList.Add(members);
        }
        
        public Member RemoveMember(int id)
        {
            Member members = GetMember(id);
            if (memberList.Remove(members))
            {
                return members;
            }
            return null!;
        } 
        // Read listen af alle members
        public List<Member> GetAllMembers()
        {
            return memberList;
        }

        //Find den enkelte member med id ?
        public Member GetMember(int id)
        {
            foreach (Member members in memberList) //brug en foreach som løber listen igennem for at finde member med id ?
            {
                if (members.Id == id) return members;
                
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
                return NewMember; 
            }
            return null!; 
        }
    } 
}