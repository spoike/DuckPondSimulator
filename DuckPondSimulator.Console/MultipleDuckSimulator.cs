using System;
using System.Collections.Generic;

namespace DuckPond.ConsoleApp
{
    public class MultipleDuckSimulator : IDisposable
    {
        private readonly IList<SingleDuckSimulator> _singleDuckSimulators = new List<SingleDuckSimulator>();

        public void BeginDuckSimulator(SingleDuckSimulator duckSim)
        {
            _singleDuckSimulators.Add(duckSim);
            duckSim.Begin();
        }

        public void Dispose()
        {
            foreach (var d in _singleDuckSimulators)
            {
                d.Dispose();
            }
        }
    }
}