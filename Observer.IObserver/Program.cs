using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.IObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            StockTicker stockTicker = new StockTicker();
            MicrosoftMonitor microsoftMonitor = new MicrosoftMonitor();
            GoogleMonitor googleMonitor = new GoogleMonitor();

            using(stockTicker.Subscribe(microsoftMonitor))
            using (stockTicker.Subscribe(googleMonitor))
            {
                foreach (var stock in SampleData.GetNext())
                {
                    stockTicker.Stock = stock;
                }
            }
        }
    }
}
