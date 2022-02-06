using Strategy.VariableBehavior.Interfaces;
using System;

namespace Strategy.VariableBehavior.Quack
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Duck can't quack");
        }
    }
}
