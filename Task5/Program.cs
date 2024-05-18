using System;
namespace Task5
{


    public static class Program
    {
        public static void Main()
        {
            Electronic machine = new Electronic("hair-dryer",300,"gold");
            Clothes clothes = new Clothes("DG", 500, "Xl");
            Clothes clothes2 = new Clothes("Gucci", 100, "S");
            Order order = new Order();
            order.AddProduct(machine);
            order.AddProduct(clothes);
            order.AddProduct(clothes2);
            order.RemoveProduct(clothes);
            order.GetDetails();
            Console.WriteLine(order.GetTotalAmount());


        }
    }
}