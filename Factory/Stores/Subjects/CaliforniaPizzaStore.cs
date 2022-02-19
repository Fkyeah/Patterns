using Factory.Ingredients.Factories;
using Factory.Ingredients.Factories.Interfaces;
using Factory.Pizzas.Base.Enums;
using Factory.Pizzas.Base.Interfaces;
using Factory.Pizzas.Subjects.CaliforniaPizzas;
using Factory.Stores.Base;

namespace Factory.Stores.Subjects
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        public CaliforniaPizzaStore()
        {
            _ingredientFactory = new CaliforniaPizzaIngredientFactory();
        }

        private IPizzaIngredientFactory _ingredientFactory;

        public override IPizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new CaliforniaCityCheesePizza(_ingredientFactory);
                case PizzaType.Greek:
                    return new CaliforniaCityGreekPizza(_ingredientFactory);
                case PizzaType.Pepperoni:
                    return new CaliforniaCityPepperoniPizza(_ingredientFactory);
                case PizzaType.Clam:
                    return new CaliforniaCityClamPizza(_ingredientFactory);
                case PizzaType.Veggie:
                    return new CaliforniaCityVeggiePizza(_ingredientFactory);
                default:
                    return null;
            }
        }
    }
}
