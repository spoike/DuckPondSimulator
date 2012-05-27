using System;

namespace DuckPond.ConsoleApp.Behaviors
{
    public class Quack : IQuackBehavior
    {
        public void PerformQuack(string name)
        {
            Console.WriteLine(name + ": Quacks");
        }
    }
}