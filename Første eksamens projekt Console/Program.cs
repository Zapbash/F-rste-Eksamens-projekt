using Første_Eksamens_projekt;
using System;

namespace BookingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize repositories
            MemberRepo memberRepo = new MemberRepo();
            BoatRepo boatRepo = new BoatRepo();
            BookingRepo bookingRepo = new BookingRepo();

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

            // Boat and booking process
            Console.WriteLine("Select a member (1 or 2):");
            int memberId = int.Parse(Console.ReadLine());
            Member selectedMember = memberRepo.GetMember(memberId);

            Console.WriteLine("Select a boat (1 or 2):");
            int boatId = int.Parse(Console.ReadLine());
            Boat selectedBoat = boatRepo.GetBoat(boatId);

            // Input booking dates
            Console.WriteLine("Enter the start date (yyyy-mm-dd):");
            DateTime startDate;
            while (!DateTime.TryParse(Console.ReadLine(), out startDate))
            {
                Console.WriteLine("Invalid date format. Please enter the start date in the correct format (yyyy-mm-dd).");
            }

            Console.WriteLine("Enter the end date (yyyy-mm-dd):");
            DateTime endDate;
            while (!DateTime.TryParse(Console.ReadLine(), out endDate))
            {
                Console.WriteLine("Invalid date format. Please enter the end date in the correct format (yyyy-mm-dd).");
            }

            // Create a new booking
            var booking = new Booking
            {
                MemberId = selectedMember.Id,
                BoatId = selectedBoat.Id,
                StartDate = startDate,
                EndDate = endDate
            };

            try
            {
                // Calculate the total price for the booking
                double totalPrice = bookingRepo.CalculateTotalPrice(booking, selectedBoat);
                booking.TotalPrice = totalPrice;

                // Add the booking to the repo
                bookingRepo.AddBooking(booking);

                // Display the booking details
                Console.WriteLine($"Booking confirmed for {selectedMember.Name} to rent {selectedBoat.Name} from {startDate.ToShortDateString()} to {endDate.ToShortDateString()}.");
                Console.WriteLine($"Total Price: {totalPrice:C}");
            }
            catch (ArgumentException ex)
            {
                // Handle any error in price calculation
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Wait for user input to close the program
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
