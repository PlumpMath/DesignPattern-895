using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.EventAndDelegate
{
    class StockChangeEventArgs : EventArgs
    {
        public Stock Stock { get; set; }
        public StockChangeEventArgs(Stock stock)
        {
            Stock = stock;
        }
    }
}
