using Første_Eksamens_projekt;
using System;

namespace BookingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Repo
            MemberRepo memberRepo = new MemberRepo();

            // Add a new member to the MemberRepo
            memberRepo.AddMember(new Member(4, "Test User", 123456, "test@example.com", DateTime.Now));
            Console.WriteLine($"Number of members: {memberRepo.GetAllMembers().Count}"); // Expected output: 4

            // Remove a member from the MemberRepo
            memberRepo.RemoveMember(1);
            Console.WriteLine($"Number of members: {memberRepo.GetAllMembers().Count}"); // Expected output: 2

            // Retrieve and print member details
            Member member = memberRepo.GetMember(2);
            Console.WriteLine($"Member name: {member?.Name}"); // Expected output: "Egon Olsen"

            // Update a member's details
            Member updatedMember = new Member(2, "Benny Updated", 99887766, "updated.benny@example.com", new DateTime(1986, 9, 25));
            Member result = memberRepo.UpdateMemberRepo(updatedMember);
            Console.WriteLine($"Updated member name: {result?.Name}"); // Expected output: "Benny Updated"


            // test af EventRepo
            Event event2 = new Event(2, "køge", "20/12/2024", "8:20", "jul", "Peppernøder og gløg");
            Event event3 = new Event(3, "Roskilde", "21/12/2024", "9:30", "julefrokost", "Gaver og gløg");
            Event event4 = new Event(4, "København", "22/12/2024", "10:30", "juletræ", "dans om juletræ");
            Blog blog = new Blog();
            blog.Add(event2);
            blog.Add(event3);
            blog.Add(event4);
            blog.Remove(2);
            blog.UpdateEvent(new Event(3, "odense", "01/13/2025", "12:30", "julefrokost", "Gaver og gløg"));
            
            

            // Create some members and an event for testing event functionality
            Member member1 = new Member(1, "Lars", 12345678, "Lars@gmail.com", new DateTime(1980, 8, 28));
            Member member2 = new Member(2, "Jens", 23456789, "Jens@gmail.com", new DateTime(1998, 2, 23));
            Event event1 = new Event(5, "Køge", "2024-02-02", "18:36", "jul", "Jul i Nisseland");
            event1.AddEventMember(member1);
            event1.AddEventMember(member2);

            // Print members of the event
            Console.WriteLine("Event Members:");
            foreach (Member eventMember in event1.PrintMembers())
            {
                Console.WriteLine(eventMember.ToString());
            }

            // Remove a member from the event
            Console.WriteLine($"Removing member with ID 2: {event1.RemoveEventMember(2)}");
            Console.WriteLine("Updated Event Members:");
            foreach (Member eventMember in event1.PrintMembers())
            {
                Console.WriteLine(eventMember.ToString());
            }


            //test af BoatRepo
            Boat boat14 = new Boat(14, "ooo", "Optimist Beginner", 1001, "Begynderjolle til børn fra 10 år og op.", false, 500);
            Boat boat15 = new Boat(15, "ppp", "Tera Mini", 1002, "Moderne begynderjolle for unge fra 8 år. Selvlænsende med 2.7 m2 sejl.", false, 600);
            Boat boat16 = new Boat(16, "qqq", "Tera Sport", 1003, "Tera-jolle med 3.7 m2 sejl. Hurtigere end Optimist-jollen.", false, 650);
            BoatRepo boatRep = new  BoatRepo();
            boatRep.AddBoat(boat14);
            boatRep.AddBoat(boat15);
            boatRep.AddBoat(boat16);
            boatRep.RemoveBoat(14);
            boatRep.UpdateBoat(new Boat(16, "Tera Sport", "Terra Sport", 1003, "Tera-jolle med 3.7 m2 sejl. Hurtigere end Optimist-jollen.", false, 600));


            // Test af bookingRepo
            BookingRepo bookingRepo1= new BookingRepo();
            DateTime expectedStartDate = DateTime.Now;
            DateTime expectedEndDate = new DateTime(2024, 12, 30);
           
            
            Booking booking1 = new Booking(1, member1, boat16,expectedStartDate,expectedEndDate);
            Console.WriteLine("booking ");
            Console.WriteLine(booking1.ToString());
            Console.WriteLine(booking1.TotalPrice);


            foreach (Event events in blog.eventDict.Values)
            {
                Console.WriteLine(events.ToString());
                Console.WriteLine("\n");
            }

            foreach (Boat boats in boatRep.GetAllBoat())
            {
                Console.WriteLine(boats.ToString());
            }

            
        }


    }
}