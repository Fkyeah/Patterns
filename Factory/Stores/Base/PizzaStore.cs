using Factory.Pizzas.Base.Enums;
using Factory.Pizzas.Base.Interfaces;

namespace Factory.Stores.Base
{
    public abstract class PizzaStore
    {
        public IPizza OrderPizza(PizzaType type)
        {
            IPizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract IPizza CreatePizza(PizzaType type);
    }
}
