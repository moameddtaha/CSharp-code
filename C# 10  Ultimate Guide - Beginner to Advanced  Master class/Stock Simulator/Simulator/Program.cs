namespace Simulator
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var stocks = new List<Stock>
            {
                new Stock("AAPL", 150.0),
                new Stock("GOOGLE", 2500.0),
                new Stock("TSLA", 700.0)
            };

            var cancellationTokenSource = new CancellationTokenSource();

            // Start the price generator task
            var priceGeneratorTask = StockPriceGenerator.StartPriceGenerator(stocks, cancellationTokenSource.Token);

            Task uiTask = null;

            try
            {
                // Start the UI
                uiTask = Stock.DisplayStockData(stocks, cancellationTokenSource.Token);

                // Wait for user to exit (Ctrl+C)
                Console.CancelKeyPress += (sender, e) =>
                {
                    e.Cancel = true;
                    cancellationTokenSource.Cancel();
                    Console.WriteLine("Press any key to exit");
                };
                // Wait for both tasks to complete
                await Task.WhenAll(priceGeneratorTask, uiTask);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Ensure hte price generator task is stopped
                cancellationTokenSource?.Cancel();
                await Task.WhenAll(priceGeneratorTask, uiTask);
            }
        }
    }
}
