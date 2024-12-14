using Første_Eksamens_projekt;
using System.Diagnostics.CodeAnalysis;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    MemberRepo repo = new MemberRepo();
    repo.AddMember(new Member(4, "Test User", 123456, "test@example.com", DateTime.Now));
    Console.WriteLine(repo.GetAllMembers().Count); // Forventet output: 4


repo.RemoveMember(1);
Console.WriteLine(repo.GetAllMembers().Count); // Forventet output: 2


Member member = repo.GetMember(2);
Console.WriteLine(member?.Name); // Forventet output: "Egon Olsen"


Member updatedMember = new Member(2, "Benny Updated", 99887766, "updated.benny@example.com", new DateTime(1986, 9, 25));
Member result = repo.UpdateMemberRepo(updatedMember);
Console.WriteLine(result?.Name);


Member member1 = new Member(1, "lars", 12345678, "Lars@gmail.com", new DateTime (1980, 8, 28));
Member member2 = new Member(2,"jens",23456789,"Jens@gmailcom",new DateTime(1998,2,23));
Event event1 = new Event(5, "køge", "2/2/2024", "18.36", "jul", "jul i nisseland");
event1.AddEventMember(member1);
event1.AddEventMember(member2);

foreach (Member members in event1.PrintMembers()) // printer vores liste 
{
    Console.WriteLine(members.ToString());
}




Console.WriteLine(event1.RemoveEventMember(2));
foreach (Member members in event1.PrintMembers()) // printer vores liste 
{
    Console.WriteLine(members.ToString());
}

