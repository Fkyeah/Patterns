using Factory.Ingredients.Base;
using Factory.Ingredients.Factories.Interfaces;
using Factory.Ingredients.Subjects.CaliforniaIngredients;

namespace Factory.Ingredients.Factories
{
    public class CaliforniaPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese() => new GoatCheese();

        public Clams CreateClams() => new Calamari();

        public Dough CreateDough() => new VeryThinCrust();

        public Sauce CreateSauce() => new BruschettaSauce();
    }
}
