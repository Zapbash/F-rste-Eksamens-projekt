using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    public class Boat
    {
        
        public int Id { get; set; }
		public string BoatType {get;set;}
        public string Name {get;set;}
        public int SailNumber { get;set;}
        public string Description {get;set;}

        public bool IsBooked {get;set;}

        public double Price;

       
        

           public Boat(int id, string boatType, string name, int sailNumber, string description, bool isBooked, double price)
		   { 
            Id = id;
            BoatType= boatType; 
            Name=name; 
            SailNumber = sailNumber;
            Description = description;
            IsBooked = isBooked;
            Price = price;


           } 

		public override string ToString()
		{
			return $"{Id}{BoatType}{Name}{SailNumber}{Description}{IsBooked} {Price}";
		}

	}

}