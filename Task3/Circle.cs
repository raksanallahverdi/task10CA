using System;
namespace Task3
{
	public class Circle:Shape
	{
		public int Radius { get; set; }
		public Circle(int radius)
		{
			this.Radius = radius;
		}
        public override double CalculateArea()
        {
			return Radius*Radius  *  3.14;
        }

    }
}

