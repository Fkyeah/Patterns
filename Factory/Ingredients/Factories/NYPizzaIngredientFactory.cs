using Factory.Ingredients.Base;
using Factory.Ingredients.Factories.Interfaces;
using Factory.Ingredients.Subjects.NYIngredients;

namespace Factory.Ingredients.Factories
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese() => new ReggianoCheese();

        public Clams CreateClams() => new FreshClams();

        public Dough CreateDough() => new ThinCrustDough();

        public Sauce CreateSauce() => new MarinaraSauce();
    }
}
