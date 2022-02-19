using Factory.Pizzas.Base.Enums;
using Factory.Stores.Base;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new PizzaStore();
            var newPizza = pizzaStore.OrderPizza(PizzaType.Cheese);
        }
    }
}
