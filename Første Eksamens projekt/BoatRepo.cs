using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
	public class BoatRepo
	{
		public List<Boat> boats = new List<Boat>();
		public void Add(Boat boats)
		{
			if (!boatList.Contains(boats)) boatList.Add(boats);

		}

		public void Remove(Boat boat) 
		
		
		{
			Boat boat = Get(id);
			if (boatList.Remove(boat))  
			{
				return boat;
			}
			return null!;

		}
}
