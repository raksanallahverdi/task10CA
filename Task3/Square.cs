using System;
namespace Task3
{
    public class Square : Shape
    {
        public int Side { get; set; }
        public Square(int side)
        {
            this.Side = side;
           
        }
        public override double CalculateArea()
        {
            return Side*Side;
        }

    }
}