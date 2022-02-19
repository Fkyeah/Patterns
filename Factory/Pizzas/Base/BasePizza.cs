using Factory.Ingredients.Base;
using Factory.Pizzas.Base.Interfaces;
using System;

namespace Factory.Pizzas.Base
{
    public abstract class BasePizza : IPizza
    {
        public string Name { get; protected set; }

        protected Dough _dough;
        protected Sauce _sauce;
        protected Cheese _cheese;
        protected Clams _clams;

        public virtual void Bake()
        {
            Console.WriteLine(string.Format("Base {0} bakes...", Name));
        }

        public virtual void Box()
        {
            Console.WriteLine(string.Format("Base {0} boxing...", Name));
        }

        public virtual void Cut()
        {
            Console.WriteLine(string.Format("Base {0} sliced...", Name));
        }

        public abstract void Prepare();
    }
}
