using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.IObserver
{
    class MicrosoftMonitor : IObserver<Stock>
    {
        public void OnCompleted()
        {
            Console.WriteLine("End of trading day.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error occured in stock ticker.");
        }

        public void OnNext(Stock value)
        {
            if (value.Symbol == "MSFT")
            {
                Console.WriteLine("Microsoft's new price is: {0}", value.Price);
            }
        }
    }
}
