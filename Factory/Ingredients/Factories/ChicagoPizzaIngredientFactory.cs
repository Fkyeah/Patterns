using Factory.Ingredients.Base;
using Factory.Ingredients.Factories.Interfaces;
using Factory.Ingredients.Subjects.ChicagoIngredients;

namespace Factory.Ingredients.Factories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese() => new MozzarellaCheese();

        public Clams CreateClams() => new FrozenClams();

        public Dough CreateDough() => new ThickCrustDough();

        public Sauce CreateSauce() => new PlumTomatoSauce();
    }
}
