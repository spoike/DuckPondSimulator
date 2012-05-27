using System;

namespace DuckPond.ConsoleApp.Behaviors
{
    public class Fly : IFlyBehavior
    {
        public void PerformFly(string name)
        {
            Console.WriteLine(name + ": Flies away");
        }
    }
}