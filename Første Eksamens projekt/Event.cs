namespace Første_Eksamens_projekt
{
    public class Event
    {
        public int Id { get; set; }
        public string Location {  get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Member> EventMembers { get; set; }

        public Event(int id, string location, string date, string time, string title, string description) 
        {
            Id = id;
            Location = location;
            Date = date;
            Time = time;
            Title = title;
            Description = description;
            EventMembers = new List<Member>();
        }

        public void AddEventMember(Member member) // join event funktion 
        {
            EventMembers.Add(member); // når man skriver eks. Event2.AddEventMember(member3) så laver den en ny liste af members under den event
        }
        public bool RemoveEventMember(int Id) // leave event funktion
        {
            foreach (Member member in EventMembers)
            {
                if (member.Id == Id)
                {
                    EventMembers.Remove(member);
                    return true;
                }
                
                
            }return false;
        }    
        public List<Member> PrintMembers() // er min print members funktion
        {
            List<Member> PrintMember = new List<Member>();           // laver ny liste af members 
                foreach (Member member in EventMembers) // for hver member member i eventmembers
                {
                    PrintMember.Add(member); //  så tilføjer den en member til listen.
                }
                return PrintMember; // returner listen
            
        }


        public override string ToString()
        {
            return $"Event: {Id} {Location} {Date} {Time} {Title} {Description}";
        }
    }
}
