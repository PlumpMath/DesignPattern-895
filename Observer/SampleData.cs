using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public static class SampleData
    {
        private static decimal[] samplePrices = new decimal[] { 10.00m, 10.25m, 555.55m, 9.50m, 9.03m };
        private static string[] sampleSymbols = new string[] { "MSFT", "MSFT", "GOOG", "MSFT", "MSFT" };
        public static IEnumerable<Stock> GetNext()
        {
            for (int i = 0; i < samplePrices.Length; i++)
            {
                Stock stock = new Stock();
                stock.Symbol = sampleSymbols[i];
                stock.Price = samplePrices[i];
                yield return stock;
            }
        }
    }
}
