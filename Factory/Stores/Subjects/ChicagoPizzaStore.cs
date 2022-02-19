using Factory.Pizzas.Base.Enums;
using Factory.Pizzas.Base.Interfaces;
using Factory.Pizzas.Subjects.ChicagoPizzas;
using Factory.Stores.Base;

namespace Factory.Stores.Subjects
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new ChicagoCityCheesePizza();
                case PizzaType.Greek:
                    return new ChicagoCityGreekPizza();
                case PizzaType.Pepperoni:
                    return new ChicagoCityPepperoniPizza();
                case PizzaType.Clam:
                    return new ChicagoCityClamPizza();
                case PizzaType.Veggie:
                    return new ChicagoCityVeggiePizza();
                default:
                    return null;
            }
        }
    }
}
