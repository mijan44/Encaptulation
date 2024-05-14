using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encaptulation.Interface
{
    public interface ICircle : IShape
    {
        double Radious { get; set; }
    }

   
}
