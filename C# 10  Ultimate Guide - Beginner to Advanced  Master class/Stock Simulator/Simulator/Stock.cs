using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    public class Stock
    {
        public string? Symbol { get; }
        public double Price { set; get; }
        public Stock(string symbol, double price)
        {
            Symbol = symbol;
            Price = price;
        }
        public async Task OnPriceChangeThresholdReached(Stock stock)
        {
            // Handle stock price change threshold reached event
            Console.WriteLine($"Price threshold reached for {stock.Symbol}. Notify users or take action.");
        }
        public static async Task DisplayStockData(List<Stock> stocks, CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Console.Clear();
                Console.WriteLine("Stocks (Press Ctrl+C to stop)");
                foreach (Stock stock in stocks)
                {
                    Console.WriteLine($"Symbol: {stock.Symbol}, Price: ${stock.Price:N}");
                }
                await Task.Delay(1001); // Update the UI every second
            }
        }
    }
}
