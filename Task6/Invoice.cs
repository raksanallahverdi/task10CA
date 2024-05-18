using System;
namespace Task6
{
	public class Invoice
	{
		public string Account { get; private set; }
        public string Customer { get; private set; }
        public string Provider { get; private set; }
		public string Article { get; set; }
		public int Quantity { get; set; }
        public double Price { get; set; }

        public Invoice(string account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }
        public double FindEdv()
		{
			return Quantity*Price * 0.18;
		}

        
		public double CostCalculation(bool needEdv)
		{
			if (needEdv)
            {
				return Price * Quantity + FindEdv();

            }
			else
			{
				return Price * Quantity;

            }

		}
	}
}

