using System;

namespace Factory.Pizzas.Base
{
    public abstract class CaliforniaCityPizza : BasePizza
    {
        public override void Bake()
        {
            Console.WriteLine(string.Format("California {0} bakes...", Name));
        }

        public override void Box()
        {
            Console.WriteLine(string.Format("California {0} boxing...", Name));
        }

        public override void Cut()
        {
            Console.WriteLine(string.Format("California {0} sliced...", Name));
        }
    }
}
