using System;
using System.Collections.Generic;
using System.Reactive.Linq;

namespace DuckPond.ConsoleApp
{
    public class SingleDuckSimulator : IDisposable
    {
        private readonly IList<IDisposable> _disposables = new List<IDisposable>();

        public Duck Duck { get; set; }

        public int SecondsDelay { get; set; }

        public int SecondsTilFlyAway { get; set; }

        public void Begin()
        {
            Observable.Start(() => Duck.Land());
            var interval = Observable.Interval(TimeSpan.FromSeconds(SecondsDelay)).Subscribe(l => Duck.Quack());
            _disposables.Add(interval);

            if (SecondsTilFlyAway > 0)
            {
                var exit = Observable.Interval(TimeSpan.FromSeconds(SecondsTilFlyAway)).Subscribe(l => FlyAway());
                _disposables.Add(exit);
            }
        }

        public void FlyAway()
        {
            Dispose();
        }

        public void Dispose()
        {
            Duck.Fly();
            foreach (var disposable in _disposables)
            {
                disposable.Dispose();
            }
        }
    }
}