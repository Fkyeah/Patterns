﻿using Factory.Pizzas.Base.Enums;
using Factory.Pizzas.Base.Interfaces;
using Factory.Stores.Base;

namespace Factory.Stores.Subjects
{
    public class NYPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(PizzaType type)
        {
            throw new System.NotImplementedException();
        }
    }
}
