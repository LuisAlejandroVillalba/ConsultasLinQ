using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteWin2
{
    public partial class Suppliers
    {
        public  string SDireccion()
        {
            return "Pais: " + Country + "- Ciudad: " + City + "- codigo Postal: " + PostalCode;
        }

        public string SWeb()
        {
            return "www." + CompanyName +".com";
        }
    }
}
