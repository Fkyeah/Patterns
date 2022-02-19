using Factory.Pizzas.Base.Enums;
using Factory.Pizzas.Base.Interfaces;
using Factory.Pizzas.Subjects.NewYorksPizzas;
using Factory.Stores.Base;

namespace Factory.Stores.Subjects
{
    public class NYPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new CheesePizza();
                case PizzaType.Greek:
                    return new GreekPizza();
                case PizzaType.Pepperoni:
                    return new PepperoniPizza();
                case PizzaType.Clam:
                    return new ClamPizza();
                case PizzaType.Veggie:
                    return new VeggiePizza();
                default:
                    return null;
            }
        }
    }
}
