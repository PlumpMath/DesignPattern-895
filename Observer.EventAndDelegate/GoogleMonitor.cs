using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.EventAndDelegate
{
    class GoogleMonitor
    {
        public GoogleMonitor(StockTicker stockTicker)
        {
            stockTicker.StockChange += new EventHandler<StockChangeEventArgs>(stockTicker_StockChange);
        }

        void stockTicker_StockChange(object sender, StockChangeEventArgs e)
        {
            CheckFilter(e.Stock);
        }

        private void CheckFilter(Stock stock)
        {
            if (stock.Symbol == "GOOG")
            {
                Console.WriteLine("Google's new price is: {0}", stock.Price);
            }
        }
    }
}
