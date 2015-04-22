using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.IObserver
{
    class Unsubcriber : IDisposable
    {
        private List<IObserver<Stock>> observers;
        private IObserver<Stock> observer;

        public Unsubcriber(List<IObserver<Stock>> observers, IObserver<Stock> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (observer != null && observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }
    }
}
