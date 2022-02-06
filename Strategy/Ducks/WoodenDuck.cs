using Strategy.VariableBehavior.Fly;
using Strategy.VariableBehavior.Quack;
using System;

namespace Strategy.Ducks
{
    public class WoodenDuck : Duck
    {
        public WoodenDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
        }
        public override void Display()
        {
            Console.Write("WoodenDuck ");
        }
    }
}
