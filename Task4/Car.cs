using System;
namespace Task4
{
	public class Car:Vehicle
	{
		public int Passengers { get; set; }
		public Car(string name,int year,string color,int passengers ):base( name, year, color)
		{
			this.Passengers = passengers;
		}

        public override string GetDetails()
        {
            return $"{Name} {Year} {Color} {Passengers}";
        }
    }
}

