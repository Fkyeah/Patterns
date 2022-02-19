using Factory.Ingredients.Factories;
using Factory.Ingredients.Factories.Interfaces;
using Factory.Pizzas.Base.Enums;
using Factory.Pizzas.Base.Interfaces;
using Factory.Pizzas.Subjects.ChicagoPizzas;
using Factory.Stores.Base;

namespace Factory.Stores.Subjects
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public ChicagoPizzaStore()
        {
            _ingredientFactory = new ChicagoPizzaIngredientFactory();
        }

        private IPizzaIngredientFactory _ingredientFactory;

        public override IPizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new ChicagoCityCheesePizza(_ingredientFactory);
                case PizzaType.Greek:
                    return new ChicagoCityGreekPizza(_ingredientFactory);
                case PizzaType.Pepperoni:
                    return new ChicagoCityPepperoniPizza(_ingredientFactory);
                case PizzaType.Clam:
                    return new ChicagoCityClamPizza(_ingredientFactory);
                case PizzaType.Veggie:
                    return new ChicagoCityVeggiePizza(_ingredientFactory);
                default:
                    return null;
            }
        }
    }
}
