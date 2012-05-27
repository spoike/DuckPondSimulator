using System;

namespace DuckPond.ConsoleApp
{
    public class Quack : IQuackBehavior
    {
        public void PerformQuack(string name)
        {
            Console.WriteLine(name + ": Quacks");
        }
    }
}