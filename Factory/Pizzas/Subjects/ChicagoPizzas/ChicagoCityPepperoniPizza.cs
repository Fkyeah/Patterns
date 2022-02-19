using Factory.Ingredients.Factories.Interfaces;
using Factory.Pizzas.Base;
using System;

namespace Factory.Pizzas.Subjects.ChicagoPizzas
{
    public class ChicagoCityPepperoniPizza : ChicagoCityPizza
    {
        public ChicagoCityPepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
            Name = GetType().Name;
        }

        private IPizzaIngredientFactory _ingredientFactory;

        public override void Prepare()
        {
            Console.WriteLine("Preparing ", Name);
            _dough = _ingredientFactory.CreateDough();
            _sauce = _ingredientFactory.CreateSauce();
            _clams = _ingredientFactory.CreateClams();
            _cheese = _ingredientFactory.CreateCheese();
        }
    }
}
