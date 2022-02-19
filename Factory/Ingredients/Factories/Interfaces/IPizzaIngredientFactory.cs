using Factory.Ingredients.Base;

namespace Factory.Ingredients.Factories.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Clams CreateClams();
    }
}
