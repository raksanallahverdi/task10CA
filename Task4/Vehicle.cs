using System;
namespace Task4
{
	public abstract class Vehicle
	{
		public string Name { get; set; }
		public int Year { get; set; }
        public string Color { get; set; }

        public Vehicle(string name,int year,string color)
		{
			this.Name = name;
            this.Year = year;
            this.Color = color;

        }

		public abstract string GetDetails();
		
	}
}

