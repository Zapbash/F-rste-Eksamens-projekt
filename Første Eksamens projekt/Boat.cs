using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Første_Eksamens_projekt
{
    public class Boat
    {
        public int Id { get; set; }
		public string BoatType {get;set;}
        public string Name {get;set;}
        public string BoatModel {get;set;}

        public int SailNumber { get;set;}
        public double Measurements {get;set;}

        public int YearOfConstruction {get;set;}
        

           public Boat(int id, string boatType, string name, string boatModel,int sailNumber, double measurements,int yearOfConstruction)
		{ 
            Id = id;
            BoatType= boatType; 
            
            Name=name;
            BoatModel = boatModel;
            SailNumber = sailNumber;
            Measurements = measurements;
            YearOfConstruction = yearOfConstruction;



		}

		public override string ToString()
		{
			return $"{Id}{BoatType}{BoatModel}{Name}{SailNumber}{Measurements}{YearOfConstruction}";
		}

	}

}