using System;
namespace Task4
{
    public class Truck : Vehicle
    {
        public int Load { get; set; }
        public Truck(string name, int year, string color, int load) : base(name, year, color)
        {
            this.Load = load;
        }

        public override string GetDetails()
        {
            return $"{Name} {Year} {Color} {Load}";
        }
    }
}

