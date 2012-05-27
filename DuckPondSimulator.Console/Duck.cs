using System;

namespace DuckPond.ConsoleApp
{
    public abstract class Duck
    {
        public string Name { get; set; }

        public int Index { get; set; }

        public string DisplayName
        {
            get
            {
                return (0 == Index) ? Name : String.Format("{0} {1}", Name, Index);
            }
        }

        public void Quack()
        {
            Console.WriteLine(DisplayName + ": Quacks");
        }

        public void Fly()
        {
            Console.WriteLine(DisplayName + ": Flies away");
        }

        public void Land()
        {
            Console.WriteLine(DisplayName + ": Lands the pond");
        }
    }
}