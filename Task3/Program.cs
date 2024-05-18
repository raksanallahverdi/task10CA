namespace Task3
{


    public static class Program
    {
        public static void Main()
        {
            Circle circle1 = new Circle(5);
            Console.WriteLine(circle1.CalculateArea());

            Triangle triangle1 = new Triangle(6, 9);
            Console.WriteLine(triangle1.CalculateArea());

            Square square1 = new Square(4);
            Console.WriteLine(square1.CalculateArea());



        }
    }
}

