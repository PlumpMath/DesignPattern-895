using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.IObserver
{
    class StockTicker : IObservable<Stock>
    {
        List<IObserver<Stock>> observers = new List<IObserver<Stock>>();
        private Stock stock;
        public Stock Stock
        {
            get
            {
                return stock;
            }
            set
            {
                stock = value;
                this.Notify(this.stock);
            }
        }

        private void Notify(Stock stock)
        {
            foreach (var observer in observers)
            {
                if (stock.Symbol == null || stock.Price < 0)
                {
                    observer.OnError(new Exception("Bad Stock data"));
                }
                else
                {
                    observer.OnNext(stock);
                }
            }
        }

        public IDisposable Subscribe(IObserver<Stock> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubcriber(observers, observer);
        }
    }
}
