using Strategy.VariableBehavior.Fly;
using Strategy.VariableBehavior.Quack;
using System;

namespace Strategy.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.Write("ModelDuck ");
        }
    }
}
