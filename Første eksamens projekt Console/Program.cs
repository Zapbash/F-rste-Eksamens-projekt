using Første_Eksamens_projekt;
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