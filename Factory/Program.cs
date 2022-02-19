using Factory.Pizzas.Base.Enums;
using Factory.Stores.Base;
using Factory.Stores.Subjects;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore newYorkStore = new NYPizzaStore();
            var newYorkPizza = newYorkStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"Now was ordered {newYorkPizza.Name}");

            PizzaStore chicagoStore = new ChicagoPizzaStore();
            var chicagoPizza = chicagoStore.OrderPizza(PizzaType.Greek);
            Console.WriteLine($"Now was ordered {chicagoPizza.Name}");

            Console.ReadKey();
        }
    }
}
