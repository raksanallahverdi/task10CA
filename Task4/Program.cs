namespace Task4
{


    public static class Program
    {
        public static void Main()
        {

            Car bmw = new Car("s-class", 2023, "red",2);
            Console.WriteLine(bmw.GetDetails());

            Truck mercedes = new Truck("bestModelTruck", 2030, "titanium", 330);
            Console.WriteLine(mercedes.GetDetails());
        }
    }
}

