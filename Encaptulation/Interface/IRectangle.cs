using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encaptulation.Interface
{
    public interface IRectangle 
    {
        double Leangth { get; set; }
        double Width { get; set; }

        public void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with length {Leangth} and width {Width}");
        }
    }
}
