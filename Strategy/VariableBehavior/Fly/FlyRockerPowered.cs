using Strategy.VariableBehavior.Interfaces;
using System;

namespace Strategy.VariableBehavior.Fly
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Rocket Powered fly");
        }
    }
}
