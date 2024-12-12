using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    public class Blog
    {
        public List<Event> eventList = new List<Event>();

        public void Add(Event begivenhed) // ved hjælp af metode så adder den en event til vores event repo
        {
            if (!eventList.Contains(begivenhed)) eventList.Add(begivenhed);  //hvis eventliste ikke indeholder begivenhed så adder den en begivenhed 
        }

        public Event Remove(int id)  // vores remove fjerne en begivenhed ud fra dens id
        {   
            Event begivenhed = Get(id); // kalder på vores get metode til at lede efter den specifike id
            if (eventList.Remove(begivenhed))  // hvis den fjerner begivenheden, så returner den begivenheden. else return null
            {
                return begivenhed;
            }
            return null!;
            
        }
        public Event Get(int Id)  // vores metode til at søge efter specifik begivenhed
        {
            foreach (Event begivenhed in eventList) // for hver begivenhed i vores eventliste 
            {
                if (begivenhed.Id == Id) return begivenhed;    // hvis begivenhedens id er det samme som det id vi søger efter så returner den
            }
            return null!; // ellers return null
        } 
        public List<Event> GetAll()  // viser bare helle vores liste 
        {
            return eventList;
        }
        public List <Event> SearchEvent(string title)  // en search metode som virker på en events title/ navn
        {
            List<Event> result = new List<Event>();   //result laver en ny liste 
                    
             foreach (Event begivenhed in eventList)   // så løber den igennem hele event listen af begivenhed
             {
                if (begivenhed.Title.ToLower().Contains(title.ToLower())) result.Add(begivenhed); // hvis begivenhed i event er det samme som den title vi søger  så har den fundet den event som det blev søgt efter, Tolover gør at stort eller småt skrift er ligemeget. de event med den rigtige title bliver lagt ned i ny result liste
             }
            return result; // her giver den tilbage listen med alle de ting som vi har event titler som vi har søft efter
        }
        public Event UpdateEventRepo(Event UpdatedEvent)  // vi kalder vores updater event for update event
        {
            Event newEvent = Get(UpdatedEvent.Id);  //  vi laver først en objekt reference newevent som bliver initialiseret ved hjælp af get metoden, som peger på det specifike objekt  
            if(newEvent != null) // hvis vores nye event ikke er null så updatere den ( den kan godt finde vores objekt) 
            {
                newEvent.Location = UpdatedEvent.Location;        
                newEvent.Date = UpdatedEvent.Date;
                newEvent.Time = UpdatedEvent.Time;
                newEvent.Title = UpdatedEvent.Title;
                newEvent.Description = UpdatedEvent.Description;
                return newEvent;
            } 
            return null!;
            
            
        }
        //public void Print()
        //{
        //    foreach (Event begivenhed in eventList) 
        //    {
        //        Console.WriteLine(begivenhed);         skal bruge denne her i console i stedet for repo
        //    }
        //}
    }
}
