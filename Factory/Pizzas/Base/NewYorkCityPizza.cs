using System;

namespace Factory.Pizzas.Base
{
    public abstract class NewYorkCityPizza : BasePizza
    {
        public override void Bake()
        {
            Console.WriteLine(string.Format("NewYork {0} bakes...", Name));
        }

        public override void Box()
        {
            Console.WriteLine(string.Format("NewYork {0} boxing...", Name));
        }

        public override void Cut()
        {
            Console.WriteLine(string.Format("NewYork {0} sliced...", Name));
        }
    }
}
