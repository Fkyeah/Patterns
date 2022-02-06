using Strategy.VariableBehavior.Fly;
using Strategy.VariableBehavior.Quack;
using System;

namespace Strategy.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeaks();
        }
        public override void Display()
        {
            Console.Write("RubberDuck ");
        }
    }
}
