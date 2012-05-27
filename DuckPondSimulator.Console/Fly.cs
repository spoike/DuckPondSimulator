using System;

namespace DuckPond.ConsoleApp
{
    public class Fly : IFlyBehavior
    {
        public void PerformFly(string name)
        {
            Console.WriteLine(name + ": Flies away");
        }
    }
}