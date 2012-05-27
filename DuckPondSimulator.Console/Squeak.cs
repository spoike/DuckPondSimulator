using System;

namespace DuckPond.ConsoleApp
{
    public class Squeak : IQuackBehavior
    {
        public void PerformQuack(string name)
        {
            Console.WriteLine(name + ": Squeaks");
        }
    }
}