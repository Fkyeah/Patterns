using Factory.Pizzas.Base.Enums;
using Factory.Pizzas.Base.Interfaces;
using Factory.Pizzas.Subjects;

namespace Factory.Factories
{
    public class SimplePizzaFactory
    {
        public IPizza CreatePizza(PizzaType type)
        {
            IPizza pizza;
            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza();
                    break;
                //case PizzaType.Greek:
                //    pizza = new GreekPizza();
                //    break;
                case PizzaType.Pepperoni:
                    pizza = new PepperoniPizza();
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza();
                    break;
                case PizzaType.Veggie:
                    pizza = new VeggiePizza();
                    break;
                default:
                    return null;
            }

            return pizza;
        }
    }
}
