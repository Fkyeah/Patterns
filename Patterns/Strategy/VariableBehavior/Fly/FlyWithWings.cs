using Strategy.VariableBehavior.Interfaces;
using System;

namespace Strategy.VariableBehavior.Fly
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Duck can fly");
        }
    }
}
