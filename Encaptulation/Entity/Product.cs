using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encaptulation.Entity
{
    public class Product
    {
        public string Name { get; set; }
        private decimal Price { get; set; }
        protected int StockQuantity { get; set; }



        public Product(string name, decimal price, int stockQuantity)
        {
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Product: {Name},Price: {Price},Stock Quantity: {StockQuantity}");
        }

        public int GetStockQuantity()
        {
            return StockQuantity;
        }
    }
}

    
