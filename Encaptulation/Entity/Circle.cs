using Encaptulation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encaptulation.Entity
{
    public class Circle : ICircle
    {
        
        public double Radious { get; set; }

        public void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {Radious}");
        }
    }
    public class Rectangle : IRectangle
    {
        
        public double Width { get; set; }
        public double Leangth { get; set ; }

        public void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with length {Leangth} and width {Width}");
        }
    }


}
