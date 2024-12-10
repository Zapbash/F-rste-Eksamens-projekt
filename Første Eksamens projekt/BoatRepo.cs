using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Første_Eksamens_projekt
{
	public class BoatRepo 
	{
		private List<Boat> boatList = new List<Boat>();

		
		public void AddBoat(Boat boats) // tilføjer en boat i reposity hvis den ikke findes 
		{
			if (!boatList.Contains(boats)) // tjekker om boat findes i listen
			{
				boatList.Add(boats); // tilføjer om boat, hvis den ikke findes 
			}
		}

	
		public Boat RemoveBoat(int id) // fjerner boat fra reposity ud fra id 
		{
			Boat boats = GetBoat(id); 
			if (boatList.Remove(boats))  // søger efter på boat og fjerner den hvis den findes  
			{
				return boats; // returnere boat som er blevet fjernet 
			}
			return null!; // returnere null hvis den ikke findes 
		}
		public Boat GetBoat(int id)  // Henter en specifik boat fra repository baseret på id
		{
			foreach (Boat boats in boatList) //  Søger alle boats igennem i listen 
			{
				if (boats.Id == id) return boats; // Sammenligner boat id med det ønskede id
			}
			return null!;// returnere null hvis boat ik findes 
		}
	
		public List<Boat> GetAllBoat()   // Returnere alle boats i repository som en liste 
		{
			return boatList;  // Resturnere hele listen af boats
		}				

		
		public Boat UpdateBoatRepo(Boat updatedBoat) // Opdatere en boat som der eksitere i repository via dens id 
		{
			Boat NewBoat = GetBoat(updatedBoat.Id);// Finder den specifikke boat som skal opdateres 
			if(NewBoat != null) // Hvis den findes 
			{						// opdatere boats nye værdier som kan være de her 							
					NewBoat.Name = updatedBoat.Name;
					NewBoat.BoatType = updatedBoat.BoatType;
					NewBoat.SailNumber = updatedBoat.SailNumber;
					NewBoat.Description = updatedBoat.Description;
					return NewBoat; // returnere derfter den boat som er blevet opdateret 
				
			}
			return null!; // returnere null hvis boaten ikke findes 
	}
	}
}







