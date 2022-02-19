﻿using Factory.Pizzas.Base.Interfaces;
using System;

namespace Factory.Pizzas.Base
{
    public abstract class CaliforniaPizza : IPizza
    {
        public virtual void Bake()
        {
            Console.WriteLine(string.Format("California {0} bakes...", GetType()));
        }

        public virtual void Box()
        {
            Console.WriteLine(string.Format("California {0} boxing...", GetType()));
        }

        public virtual void Cut()
        {
            Console.WriteLine(string.Format("California {0} sliced...", GetType()));
        }

        public virtual void Prepare()
        {
            Console.WriteLine(string.Format("California {0} prepares...", GetType()));
        }
    }
}