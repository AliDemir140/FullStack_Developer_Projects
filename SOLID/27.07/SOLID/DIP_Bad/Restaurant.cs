using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Bad
{
    internal class Restaurant//yüksek seviyeli
    {
        EtMenu etMenu = new EtMenu();//düşük seviyeli class
        TavukMenu tavukMenu=new TavukMenu();
        PizzaMenu pizzaMenu=new PizzaMenu();


        public string Tarifler()
        {
            return etMenu.Tarif() + " " + tavukMenu.Tarif() + " " + pizzaMenu.Tarif();
        }

    }
}
