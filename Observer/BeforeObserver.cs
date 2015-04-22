using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class BeforeObserver
    {
        static void Main(string[] args)
        {
            foreach (var stock in SampleData.GetNext())
            {
                if (stock.Symbol == "GOOG")
                {
                    Console.WriteLine("Google's new price is: {0}", stock.Price);
                }
                if (stock.Symbol == "MSFT")
                {
                    Console.WriteLine("Microsoft's new price is: {0}", stock.Price);
                }
            }
        }
    }
}
