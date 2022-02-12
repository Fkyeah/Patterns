using Decorator.Addons;
using Decorator.Base;
using Decorator.Beverages;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Console.WriteLine(string.Format("{0} ${1}\n", espresso.GetDescription(), espresso.Cost()));

            Beverage darkRoast = new DarkRoast();
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Mocha(darkRoast);
            darkRoast = new MilkFoam(darkRoast);
            Console.WriteLine(string.Format("{0} ${1}\n", darkRoast.GetDescription(), darkRoast.Cost()));

            Beverage houseBlend = new HouseBlend();
            houseBlend = new Cream(houseBlend);
            houseBlend = new Soya(houseBlend);
            Console.WriteLine(string.Format("{0} ${1}\n", houseBlend.GetDescription(), houseBlend.Cost()));

            Console.ReadKey();
        }
    }
}
