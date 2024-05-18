using System;
namespace Task5
{
	public class Electronic:Product
	{
		public string Material { get; set; }
		public Electronic(string name,int price,string material):base(name,price)
		{
			Material = material;
		}
        public override void GetDetails()
        {
			Console.WriteLine($"{Name} {Price} {Material}"); 
        }
    }
}

