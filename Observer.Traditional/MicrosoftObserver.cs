using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Traditional
{
    public class MicrosoftObserver : AbstractObserver
    {
        public StockTicker DataSource { get; set; }

        public MicrosoftObserver(StockTicker stockTicker)
        {
            DataSource = stockTicker;
            stockTicker.Register(this);
        }

        public override void Update()
        {
            decimal price = DataSource.Stock.Price;
            string symbol = DataSource.Stock.Symbol;
            if (symbol == "MSFT")
            { 
                Console.WriteLine("Microsoft's new price is: {0}", price);
            }
        }
    }
}
