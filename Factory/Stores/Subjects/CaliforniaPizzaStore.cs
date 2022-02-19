using Factory.Pizzas.Base.Enums;
using Factory.Pizzas.Base.Interfaces;
using Factory.Pizzas.Subjects.CaliforniaPizzas;
using Factory.Stores.Base;

namespace Factory.Stores.Subjects
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new CaliforniaCityCheesePizza();
                case PizzaType.Greek:
                    return new CaliforniaCityGreekPizza();
                case PizzaType.Pepperoni:
                    return new CaliforniaCityPepperoniPizza();
                case PizzaType.Clam:
                    return new CaliforniaCityClamPizza();
                case PizzaType.Veggie:
                    return new CaliforniaCityVeggiePizza();
                default:
                    return null;
            }
        }
    }
}
