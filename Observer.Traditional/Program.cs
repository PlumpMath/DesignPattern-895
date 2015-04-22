using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Traditional
{
    class Program
    {
        static void Main(string[] args)
        {
            StockTicker stockTicker = new StockTicker();
            GoogleObserver googleObserver = new GoogleObserver(stockTicker);
            MicrosoftObserver microsoftObserver = new MicrosoftObserver(stockTicker);
            foreach (var stock in SampleData.GetNext())
            {
                stockTicker.Stock = stock;
            }
        }
    }
}
