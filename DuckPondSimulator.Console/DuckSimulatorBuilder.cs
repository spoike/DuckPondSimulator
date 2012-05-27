using System;

namespace DuckPond.ConsoleApp
{
    public class DuckSimulatorBuilder
    {
        private static Random _random;

        public static Random Random {
            get { return _random ?? (_random = new Random()); }
            set { _random = value; }
        }

        public static MultipleDuckSimulator GetDucksSimulator(int amountOfDucks)
        {
            var sim = new MultipleDuckSimulator();
            for (var i = 1; i <= amountOfDucks; ++i )
            {
                sim.BeginDuckSimulator(GetSingleSimulator(GetRandomDuck(i)));
            }
            return sim;
        }

        public static Duck GetRandomDuck(int index)
        {
            var rnd = Random.Next(0, 1);
            Duck d;

            switch(rnd)
            {
                default:
                    d = new Duck();
                    break;
            }

            d.Index = index;
            return d;
        }

        public static SingleDuckSimulator GetSingleSimulator(Duck duck)
        {
            return GetSingleSimulator(duck, Random.Next(1, 5), Random.Next(6, 20));
        }

        public static SingleDuckSimulator GetSingleSimulator(Duck d, int quackDelay, int flyAwayDelay)
        {
            var simDuck = new SingleDuckSimulator {Duck = d, SecondsDelay = quackDelay, SecondsTilFlyAway = flyAwayDelay};
            return simDuck;
        }
    }
}