using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci
{
    public class Menu
    {
        public string MenuAdi { get; set; }
        public decimal Fiyati { get; set; }

        //Nesne adıyla çağrıldığında, combobox'ta ManuAdi + Menü şeklinde görünmesi için:
        public override string ToString()
        {
            return MenuAdi + " Menü";
        }
    }
}
