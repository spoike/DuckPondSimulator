using System;
using DuckPond.ConsoleApp.Behaviors;

namespace DuckPond.ConsoleApp
{
    public abstract class Duck
    {
        public string Name { get; set; }

        public int Index { get; set; }

        public IQuackBehavior QuackBehavior { get; set; }

        public IFlyBehavior FlyBehavior { get; set; }

        protected Duck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new Fly();
        }

        public string DisplayName
        {
            get
            {
                return (0 == Index) ? Name : String.Format("{0} {1}", Name, Index);
            }
        }

        public void Quack()
        {
            if (null != QuackBehavior) QuackBehavior.PerformQuack(DisplayName);
        }

        public void Fly()
        {
            if (null != FlyBehavior) FlyBehavior.PerformFly(DisplayName);
        }

        public void Land()
        {
            Console.WriteLine(DisplayName + ": Lands the pond");
        }
    }
}