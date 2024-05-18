using System;
namespace Task5
{
	public class Order
	{
        private Product[] products;
        public Product[] Products { get => products; }

        public Order()
        {
            products = new Product[0];
        }
        public int maxCapacity = 10;

        public void AddProduct(Product product)

        {
            if (maxCapacity > products.Length)
            {

                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;
            }
            else
            {
                Console.WriteLine("Siz maksimum saya chatmisiz");
            }
            
        }

        public void GetDetails()
        {
            foreach (var item in products)
            {
                item.GetDetails();
            }

        }

        public void RemoveProduct(Product product)
        {
            int index = Array.IndexOf(Products, product);
            if (index != -1)
            {
                for (int i = index; i < Products.Length - 1; i++)
                {
                    products[i] = products[i + 1];

                }
                Array.Resize(ref products, products.Length - 1);

            }
            else
            {
                Console.WriteLine("Bele product yoxdu");
            }
            
  
        }


        public decimal GetTotalAmount()
        {
            decimal sum = 0;
            
                
                foreach (var item in products)
                {
                    sum +=item.Price;
                }
            
    
            return sum;
        }

    }
}

