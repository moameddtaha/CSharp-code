using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    public static class StockPriceGenerator
    {
        public static async Task StartPriceGenerator(List<Stock> stocks, CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                foreach (Stock stock in stocks)
                {
                    // Simulate price change
                    var randomChange = new Random().NextDouble() * 10 - 5; // Random change between -5 and 5
                    stock.Price += randomChange;

                    // Check if price exceeded a certain threshold (e.g, 1-% change)
                    if(Math.Abs(randomChange / stock.Price) > 0.1)
                    {
                        await stock.OnPriceChangeThresholdReached(stock);
                    }
                }
                await Task.Delay(1001); // Simulate price change every second
            }
        }
    }
}
