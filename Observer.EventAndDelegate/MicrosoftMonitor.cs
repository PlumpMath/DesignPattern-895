using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.EventAndDelegate
{
    class MicrosoftMonitor
    {
        public MicrosoftMonitor(StockTicker stockTicker)
        {
            stockTicker.StockChange += new EventHandler<StockChangeEventArgs>(stockTicker_StockChange);
        }

        private void stockTicker_StockChange(object sender, StockChangeEventArgs e)
        {
            CheckFilter(e.Stock);
        }

        private void CheckFilter(Stock stock)
        {
            if (stock.Symbol == "MSFT")
            {
                Console.WriteLine("Microsoft's new price is: {0}", stock.Price);
            }
        }
    }
}
