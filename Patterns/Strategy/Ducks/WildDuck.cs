using Strategy.VariableBehavior.Fly;
using Strategy.VariableBehavior.Quack;
using System;

namespace Strategy.Ducks
{
    public class WildDuck : Duck
    {
        public WildDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quacks();
        }

        public override void Display()
        {
            Console.Write("WildDuck ");
        }
    }
}
