using Strategy.VariableBehavior.Interfaces;
using System;

namespace Strategy.VariableBehavior.Quack
{
    public class Squeaks : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Duck squeaks");
        }
    }
}
