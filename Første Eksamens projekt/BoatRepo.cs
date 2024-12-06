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

		
		public void Add(Boat boat)
		{
			if (!boatList.Contains(boat))
			{
				boatList.Add(boat);
			}
		}

	
		public Boat Remove(Boat boat)
		{
			if (boatList.Remove(boat))
			{
				return boat;
			}
			return null!;
		}

	
		public List<Boat> GetAll()
		{
			return new List<Boat>(boatList); 
		}

		
		public Boat SearchBoat(string name)
		{
			foreach (Boat boat in boatList)
			{
				if (boat.Name == name) 
				{
					return boat;
				}
			}
			return null!;
		}

		
		public Boat UpdateBoatRepo(Boat updatedBoat)
		{
			foreach (Boat existingBoat in boatList)
			{
				if (existingBoat.Id == updatedBoat.Id) 
				{
					
					existingBoat.Name = updatedBoat.Name;
					existingBoat.BoatModel = updatedBoat.BoatModel;
					existingBoat.SailNumber = updatedBoat.SailNumber;
					existingBoat.Measurements = updatedBoat.Measurements;
					existingBoat.YearOfConstruction = updatedBoat.YearOfConstruction;
					return existingBoat; 
				}
			}
			return null!; 
	}
	}
}







