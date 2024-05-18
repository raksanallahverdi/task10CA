using System;
namespace Task3
{
    public class Triangle : Shape
    {
        public int Side { get; set; }
        public int Height { get; set; }
        public Triangle(int side,int height)
        {
            this.Side = side;
            this.Height = height;
        }
        public override double CalculateArea()
        {
            return 0.5 * Side * Height;
        }

    }
}