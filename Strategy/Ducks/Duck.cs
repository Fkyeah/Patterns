using Strategy.VariableBehavior.Interfaces;
using System;

namespace Strategy.Ducks
{
    public abstract class Duck
    {

        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }

        public virtual void Swim()
        {
            Console.WriteLine("Duck can swim");
        }

        public virtual void PerfromFly()
        {
            FlyBehavior.Fly();
        }

        public virtual void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public abstract void Display();
    }
}
