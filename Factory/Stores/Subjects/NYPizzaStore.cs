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
                    return new NYCityCheesePizza();
                case PizzaType.Greek:
                    return new NYCityGreekPizza();
                case PizzaType.Pepperoni:
                    return new NYCityPepperoniPizza();
                case PizzaType.Clam:
                    return new NYCityClamPizza();
                case PizzaType.Veggie:
                    return new NYCityVeggiePizza();
                default:
                    return null;
            }
        }
    }
}
