using Factory.Pizzas.Base.Interfaces;
using System;

namespace Factory.Pizzas.Base
{
    public abstract class ChicagoCityPizza : BasePizza
    {
        public override void Bake()
        {
            Console.WriteLine(string.Format("Chicago {0} bakes...", Name));
        }

        public override void Box()
        {
            Console.WriteLine(string.Format("Chicago {0} boxing...", Name));
        }

        public override void Cut()
        {
            Console.WriteLine(string.Format("Chicago {0} sliced...", Name));
        }
    }
}
