using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encaptulation.Entity
{
    public class SubProduct : Product
    {
        public SubProduct(string name, decimal price, int stockQQuantity) : base(name, price, stockQQuantity)
        {
            
        }

        public new void DisplayProduct()
        {
            Console.WriteLine($"Product: {Name}, Stock Quantity: {StockQuantity}");
        }
    }
}
