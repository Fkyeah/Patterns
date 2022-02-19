using Factory.Base.Enums;
using Factory.Base.Interfaces;
using Factory.Subjects;

namespace Factory
{
    public class PizzaStore
    {
        public IPizza OrderPizza(PizzaType type)
        {
            IPizza pizza;
            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza();
                    break;
                case PizzaType.Greek:
                    pizza = new GreekPizza();
                    break;
                case PizzaType.Pepperoni:
                    pizza = new PepperoniPizza();
                    break;
                default:
                    return null;
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
