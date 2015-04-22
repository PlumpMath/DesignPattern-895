using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.EventAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            StockTicker stockTicker = new StockTicker();
            GoogleMonitor googleMonitor = new GoogleMonitor(stockTicker);
            MicrosoftMonitor microsoftMonitor = new MicrosoftMonitor(stockTicker);
            foreach (var stock in SampleData.GetNext())
            {
                stockTicker.Stock = stock;
            }
        }
    }
}
