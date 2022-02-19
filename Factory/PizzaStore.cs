using Factory.Base.Enums;
using Factory.Base.Interfaces;
using Factory.Factories;
using Factory.Subjects;

namespace Factory
{
    public class PizzaStore
    {
        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }

        private SimplePizzaFactory _factory;

        public IPizza OrderPizza(PizzaType type)
        {
            IPizza pizza = _factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
