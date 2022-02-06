using Strategy.Ducks;
using Strategy.VariableBehavior.Fly;
using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>
            {
                new WildDuck(),
                new HomeDuck(),
                new RubberDuck(),
                new WoodenDuck(),
            };

            Console.WriteLine("Крякаем");
            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformQuack();
            }

            Console.WriteLine("Плаваем");
            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
            }

            Console.WriteLine("Летаем");
            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerfromFly();
            }

            Console.WriteLine("Изменяем поведение во время выполнения программы");
            Duck modelDuck = new ModelDuck();
            modelDuck.Display();
            modelDuck.PerfromFly();

            modelDuck.FlyBehavior = new FlyRocketPowered();
            modelDuck.Display();
            modelDuck.PerfromFly();

            Console.ReadLine();
        }
    }
}
