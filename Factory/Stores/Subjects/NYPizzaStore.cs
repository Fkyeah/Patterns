using Factory.Ingredients.Factories;
using Factory.Ingredients.Factories.Interfaces;
using Factory.Pizzas.Base.Enums;
using Factory.Pizzas.Base.Interfaces;
using Factory.Pizzas.Subjects.NewYorksPizzas;
using Factory.Stores.Base;

namespace Factory.Stores.Subjects
{
    public class NYPizzaStore : PizzaStore
    {
        public NYPizzaStore()
        {
            _ingredientFactory = new NYPizzaIngredientFactory();
        }

        private IPizzaIngredientFactory _ingredientFactory;

        public override IPizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new NYCityCheesePizza(_ingredientFactory);
                case PizzaType.Greek:
                    return new NYCityGreekPizza(_ingredientFactory);
                case PizzaType.Pepperoni:
                    return new NYCityPepperoniPizza(_ingredientFactory);
                case PizzaType.Clam:
                    return new NYCityClamPizza(_ingredientFactory);
                case PizzaType.Veggie:
                    return new NYCityVeggiePizza(_ingredientFactory);
                default:
                    return null;
            }
        }
    }
}
