using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    public class MemberRepo
    {

        public MemberRepo() {
            AddMockData();
        }
         
        public List<Member> memberList = new List<Member>();
       
        public void AddMember(Member members) // tilføjer en member til repository
        {
            if (!memberList.Contains(members)) memberList.Add(members); // Tjekker om member er findes i listen og derefter tilføjer den hvis den ik findes
        }
        
        public Member RemoveMember(int id) // Fjener en member  ud fra id
        {
            Member members = GetMember(id);// Finder en member via Get funktionen
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
                if (members.Id == id) return members; // Tjekker om id'et mather det som vi søger efter og derefter returnere  hvis den findes
                
            }
            return null!; // Returner null, hvis medlemmet ikke findes
        }
        public List<Member> SearchMember(string name) // search member har en parameter som er string name( har en retur tpe som er list member), har med hensigt at retunere alle de Member hvis navn matcher det navn som vi giver i argument
        {
            List<Member> membersResult = new List<Member>(); // memberresult laver en ny liste af member
            foreach (Member members in memberList) // for hver memer member in memberlist (den går igennem listen)
            {
                if (members.Name.ToLower().Contains(name.ToLower())) membersResult.Add(members); // hvis members navn indeholder det samme som det argument vi gav(tolower betyder stort og småt er ligemeget), så adder den den member til memberresult.
            }
            return membersResult; //retunere derefter listen af navne som passer med det argument vi gav
        }
        

        // UpdateMember 
        public Member UpdateMemberRepo(Member UpdatedMember) // indeholder de opdatederede values til en eksisterende Member
        {
            Member NewMember = GetMember(UpdatedMember.Id); // brug getmember metoden til at finde memberen som skal opdateres
            if (NewMember != null) // hvis newmember ikke er null(den findes)
            {
                NewMember.Name = UpdatedMember.Name; // properties overskrives med nye values fra updatemember
                NewMember.Email = UpdatedMember.Email;
                NewMember.PhoneNumber = UpdatedMember.PhoneNumber;
                NewMember.BirthDay = UpdatedMember.BirthDay;
                return NewMember;  // Returnere den opdateret member 
            }
            return null!; // Returnere null, hvis den member ikke findes 
        }
        private void AddMockData()
        {
            memberList.Add(new Member(1, "Egon Olsen", 12345678, "Egon@example.com", new DateTime(1990, 5, 10)));
            memberList.Add(new Member(2, "Benny Frandsen", 87654321, "Benny@example.com", new DateTime(1985, 8, 15)));
            memberList.Add(new Member(3, "Kjeld Jensen", 23456789, "Kjeld@example.com", new DateTime(2000, 2, 20)));

        }
    } 

}