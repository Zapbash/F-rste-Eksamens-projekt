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

        public Event(int id, string location, string date, string time, string title, string description) 
        {
            Id = id;
            Location = location;
            Date = date;
            Time = time;
            Title = title;
            Description = description;
        }
        public override string ToString()
        {
            return $"Event: {Id} {Location} {Date} {Time} {Title} {Description}";
        }
    }
}
