using Factory.Ingredients.Factories.Interfaces;
using Factory.Pizzas.Base;
using System;

namespace Factory.Pizzas.Subjects.ChicagoPizzas
{
    public class ChicagoCityClamPizza : ChicagoCityPizza
    {
        public ChicagoCityClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
            Name = GetType().Name;
        }

        private IPizzaIngredientFactory _ingredientFactory;

        public override void Prepare()
        {
            Console.WriteLine(string.Format("Preparing {0}", Name));
            _dough = _ingredientFactory.CreateDough();
            _sauce = _ingredientFactory.CreateSauce();
            _clams = _ingredientFactory.CreateClams();
            _cheese = _ingredientFactory.CreateCheese();
        }
    }
}
