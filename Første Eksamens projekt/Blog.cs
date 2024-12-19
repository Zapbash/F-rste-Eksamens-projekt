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

        public bool Add(Event begivenhed) // ved hjælp af metode så adder den en event til vores event repo
        {
            if (!eventDict.ContainsKey(begivenhed.Id)) 
            {
                
               eventDict.Add(begivenhed.Id,begivenhed); //hvis eventliste ikke indeholder begivenhed så adder den en begivenhed 
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
        public List <Event> SearchEvent(string title)  // en search metode som virker på en events title/ navn
        {
            List<Event> result = new List<Event>();   //result laver en ny liste 
                    
             foreach (Event begivenhed in eventDict.Values)   // så løber den igennem hele event listen af begivenhed
             {
                if (begivenhed.Title.ToLower().Contains(title.ToLower())) result.Add(begivenhed); // hvis begivenhed i event er det samme som den title vi søger  så har den fundet den event som det blev søgt efter, Tolover gør at stort eller småt skrift er ligemeget. de event med den rigtige title bliver lagt ned i ny result liste
             }
            return result; // her giver den tilbage listen med alle de ting som vi har event titler som vi har søft efter
        }

        
        public Event UpdateEventRepo(Event UpdatedEvent)  // vi kalder vores updater event for update event
        {                                            // check console og om updateeventrepo skal laves som i uml oopgave.
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
        
           
    }
}
