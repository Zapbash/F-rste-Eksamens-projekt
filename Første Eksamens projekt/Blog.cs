using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    public class Blog
    {
        public Dictionary<int,Event> eventDict = new();

        public bool Add(Event begivenhed) 
        {
            if (!eventDict.ContainsKey(begivenhed.Id))   // hvis evendict ikke indeholder den begivenhed som søges efter med id
            {
                
               eventDict.Add(begivenhed.Id,begivenhed); // så adder den begivenheden (begivenhed.id værende key og begivenhed valure)
                return true;  
            }            
               return false;
            
            
        }
        public bool Remove(int id)  // vores remove fjerne en begivenhed ud fra dens id
        {   
            return eventDict.Remove(id);      
        }
        public Event Get(int Id)  
        {
           return (eventDict.ContainsKey(Id)) ? eventDict[Id] : null!; // hvis eventdict indeholder key så return ellers return null 
        } 
        public List<Event> GetAll()  
        {
            return eventDict.Values.ToList(); // returner hele evendict ved at konvetere vores values til en list
        }
        public List <Event> SearchEvent(string title)  // en search metode som virker på en title
        {
            List<Event> result = new List<Event>();   //result laver en ny liste 
                    
             foreach (Event begivenhed in eventDict.Values)   // så løber den igennem hele event listen af begivenhed
             {
                if (begivenhed.Title.ToLower().Contains(title.ToLower())) result.Add(begivenhed); // hvis begivenhed i event er det samme som den title vi søger  så har den fundet den event som det blev søgt efter, Tolover gør at stort eller småt skrift er ligemeget. de event med den rigtige title bliver lagt ned i ny result liste
             }
            return result; // her giver den tilbage listen med alle de ting som vi har event titler som vi har søft efter
        }

        
        public Event UpdateEvent(Event UpdatedEvent)  // indeholder de opdaterede værdier til en Event
        {                                            
            Event newEvent = Get(UpdatedEvent.Id);  //  bruger get funktion til af finde den event med samme id som updatedven.id
            if(newEvent != null) // hvis vores nye event ikke er null så updatere den ( den kan godt finde vores objekt) 
            {
                newEvent.Location = UpdatedEvent.Location;        // properties overskrives med den nye valure fra updatedevent.
                newEvent.Date = UpdatedEvent.Date;
                newEvent.Time = UpdatedEvent.Time;
                newEvent.Title = UpdatedEvent.Title;
                newEvent.Description = UpdatedEvent.Description;
                return newEvent;
            } 
            return null!;
            
            
        }
        
           
    }
}
