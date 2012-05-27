using System;

namespace DuckPond.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the duck pond simulator");
            Console.WriteLine();

            Console.WriteLine("Enter number of random ducks: ");

            int duckAmount = 0;
            while (0 == duckAmount)
            {
                Console.Write("> ");
                string line = Console.ReadLine();
                Int32.TryParse(line, out duckAmount);
                if (duckAmount == 0)
                {
                    Console.WriteLine("Error: Input was not a number. Try again: ");
                }
            }

            using (DuckSimulatorBuilder.GetDucksSimulator(duckAmount))
            {
                Console.ReadKey();
            }

            Console.WriteLine();
            Console.WriteLine("Duck simulation begins.");
            Console.WriteLine("Press any key to quit...");
            Console.WriteLine();
            Console.WriteLine("You leave the pond");
        }
    }
}
