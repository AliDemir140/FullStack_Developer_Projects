using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Bad
{
    internal class Coffee
    {
       public static decimal GetTotalPrice(int amount, CoffeeType coffee)
        {
            decimal totalPrice = 0;

            //Filtre 100TL
            //Mocha 120TL
            //Latte 130 TL
            switch (coffee)
            {
                case CoffeeType.Mocha:
                    totalPrice = amount * 120;
                    break;

                case CoffeeType.Latte:
                    totalPrice = amount * 130;
                    break;

                case CoffeeType.Filtre:
                    totalPrice = amount * 100;
                    break;

                case CoffeeType.Americano:
                    totalPrice = amount * 150;
                    break;
            }



            return totalPrice;
        }
    }
}
