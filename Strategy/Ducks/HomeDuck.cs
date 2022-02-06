using Strategy.VariableBehavior.Fly;
using Strategy.VariableBehavior.Quack;
using System;

namespace Strategy.Ducks
{
    public class HomeDuck : Duck
    {
        public HomeDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quacks();
        }
        public override void Display()
        {
            Console.Write("HomeDuck ");
        }
    }
}
