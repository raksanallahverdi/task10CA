using System;
namespace Task5
{
	public class Clothes:Product
		
	{
        public string Size { get; set; }
		public Clothes(string name, int price, string size) : base(name, price)
		{
			Size = size;
		}
        public override void GetDetails()
        {
            Console.WriteLine($"{Name} {Price} {Size}");
        }
    }
}

