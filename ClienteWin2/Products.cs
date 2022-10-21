using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteWin2
{
    public partial class Products
    {
        public string PUnitPUnitSt()
        {
            return "S/. " + UnitPrice * UnitsInStock;
        }
       
    }
}
