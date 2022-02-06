using Strategy.VariableBehavior.Interfaces;
using System;

namespace Strategy.VariableBehavior.Quack
{
    public class Quacks : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Duck quacks");
        }
    }
}
