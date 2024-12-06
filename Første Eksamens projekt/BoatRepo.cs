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

		
		public void AddBoat(Boat boats)
		{
			if (!boatList.Contains(boats))
			{
				boatList.Add(boats);
			}
		}

	
		public Boat RemoveBoat(int id)
		{
			Boat boats = GetBoat(id);
			if (boatList.Remove(boats))
			{
				return boats;
			}
			return null!;
		}
		public Boat GetBoat(int id)
		{
			foreach (Boat boats in boatList)
			{
				if (boats.Id == id) return boats;
			}
			return null!;
		}
	
		public List<Boat> GetAllBoat()   // spørg angende om eks remove bare kan bruges eller om det skal hedde removeboat
		{
			return boatList;
		}				

		
		public Boat UpdateBoatRepo(Boat updatedBoat)
		{
			Boat NewBoat = GetBoat(updatedBoat.Id);
			if(NewBoat != null)
			{													
					NewBoat.Name = updatedBoat.Name;
					NewBoat.BoatModel = updatedBoat.BoatModel;
					NewBoat.SailNumber = updatedBoat.SailNumber;
					NewBoat.Measurements = updatedBoat.Measurements;
					NewBoat.YearOfConstruction = updatedBoat.YearOfConstruction;
					return NewBoat; 
				
			}
			return null!; 
	}
	}
}







