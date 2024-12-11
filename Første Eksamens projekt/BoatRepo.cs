﻿using System;
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
        public BoatRepo()
        {
            AddMockData();
        }
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
        private void AddMockData()
        {
            boatList.Add(new Boat(1, "Optimistjolle", "Optimist Beginner", 1001, "Begynderjolle til børn fra 10 år og op."));
            boatList.Add(new Boat(2, "Tera", "Tera Mini", 1002, "Moderne begynderjolle for unge fra 8 år. Selvlænsende med 2.7 m2 sejl."));
            boatList.Add(new Boat(3, "Tera", "Tera Sport", 1003, "Tera-jolle med 3.7 m2 sejl, hurtigere end Optimist-jollen."));
            boatList.Add(new Boat(4, "Tera", "Tera Pro", 1004, "Avanceret Tera-jolle med 4.8 m2 sejl. God til træning."));
            boatList.Add(new Boat(5, "Feva", "Feva S", 1005, "To-mands jolle. Længde: 3,64 m. Storsejl: 5.5 kvm."));
            boatList.Add(new Boat(6, "Feva", "Feva XL", 1006, "Sportslig Feva-jolle med 6.5 kvm storsejl. God til unge."));
            boatList.Add(new Boat(7, "Laserjolle", "Laser Standard", 1007, "Enkel jolle med standardrig til sejlere over 60 kg."));
            boatList.Add(new Boat(8, "Laserjolle", "Laser Radial", 1008, "Mellemrig, ofte brugt af kvinder. Ideel vægt: 55-70 kg."));
            boatList.Add(new Boat(9, "Laserjolle", "Laser 4.7", 1009, "Mindste rig til børn, vægtklasse ned til 35 kg."));
            boatList.Add(new Boat(10, "Europajolle", "Europa", 1010, "Olympisk jolle for kvinder, udbredt i Europa. Klubben råder over 3."));
            boatList.Add(new Boat(11, "Snipejolle", "Snipe", 1011, "Tomands kapsejladsjolle, kendt for taktik og sociale regattaer."));
            boatList.Add(new Boat(12, "Wayfarer", "Wayfarer Senior", 1012, "Søstærk jolle for seniorer. Kan bruges til både kapsejlads og ture."));
            boatList.Add(new Boat(13, "Lynæs", "Lynæs 14", 1013, "Stabil kølbåd til familier og seniorer. Klubben har 4 Lynæs 14."));
        }

    }
}







