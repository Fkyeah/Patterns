using Strategy.VariableBehavior.Interfaces;
using System;

namespace Strategy.VariableBehavior.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Duck can't fly");
        }
    }
}
