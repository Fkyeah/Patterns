﻿using Decorator.Base;

namespace Decorator.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
        }

        public override double Cost() => 1.99;
    }
}
