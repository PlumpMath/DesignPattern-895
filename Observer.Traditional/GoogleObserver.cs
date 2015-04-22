using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Traditional
{
    public class GoogleObserver : AbstractObserver
    {
        public StockTicker DataSource { get; set; }

        public GoogleObserver(StockTicker stockTicker)
        {
            DataSource = stockTicker;
            stockTicker.Register(this);
        }

        public override void Update()
        {
            decimal price = DataSource.Stock.Price;
            string symbol = DataSource.Stock.Symbol;
            if (symbol == "GOOG")
            {
                Console.WriteLine("Google's new price is: {0}", price);
            }
        }
    }
}
