

using System.Diagnostics;

public class Print
{
    // Property to store the count of numbers to print
    public int Count { set; get; }

    // Method to print numbers in ascending order from 1 to Count
    public void PrintAscending()
    { 
        try{
            // Loop to print numbers from 1 to Count
            for (int i = 1; i <= Count; i++)
            {
                // Print the current thread name and the number
                System.Console.WriteLine($"{Thread.CurrentThread.Name}: Number {i}");
                
                // Sleep for 1 second between prints
                Thread.Sleep(1000);
            }
        }
        catch(ThreadInterruptedException){
            // Handle thread interruption
            System.Console.WriteLine($"{Thread.CurrentThread.Name} interrupted");
        }
        catch(Exception e){
            // Handle any other exceptions and print the error message and stack trace
            System.Console.WriteLine($"Somthing went wrong, exeption raised \n {e.Message} \n {e.StackTrace}");
        }
    }

    // Method to print alphabet letters from A to Z
    public void PrintAlphabet()
    {
        try{
            // Loop to print letters from A to Z
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                // Print the current thread name and the letter
                System.Console.WriteLine($"{Thread.CurrentThread.Name}: {letter}");

                // Sleep for 0.5 seconds between prints
                Thread.Sleep(500);
            }
        }
        catch(ThreadInterruptedException){
            // Handle thread interruption
            System.Console.WriteLine($"{Thread.CurrentThread.Name} interrupted");
        }
        catch(Exception e){
            // Handle any other exceptions and print the error message and stack trace
            System.Console.WriteLine($"Somthing went wrong, exeption raised \n {e.Message} \n {e.StackTrace}");
        }
    }
    
    // Method to print random numbers between 1 and 100 for 5 seconds
    public void PrintRandomNumbers()
    {
        try{
            Random random = new Random();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Loop to print random numbers for 5 seconds
            while(stopwatch.Elapsed.TotalSeconds < 5){
                // Generate a random number between 1 and 100
                int randomNumber = random.Next(1, 101);

                // Print the current thread name and the random number
                System.Console.WriteLine($"{Thread.CurrentThread.Name}: Random Number: {randomNumber}");

                // Sleep for 0.5 seconds between prints
                Thread.Sleep(500);
            }
        }
        catch(ThreadInterruptedException){
            // Handle thread interruption
            System.Console.WriteLine($"{Thread.CurrentThread.Name} interrupted");
        }
        catch(Exception e){
            // Handle any other exceptions and print the error message and stack trace
            System.Console.WriteLine($"Somthing went wrong, exeption raised \n {e.Message} \n {e.StackTrace}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Print p = new Print();
        p.Count = 100;

        // Thread 1
        ThreadStart ThreadStart1 = new ThreadStart(p.PrintAscending);
        Thread printAscending = new Thread(ThreadStart1) { Name = "Number Thread" };
        printAscending.Start();

        // Thread 2
        Thread printAlphabet = new Thread(() => p.PrintAlphabet()) { Name = "Alphabet Thread" };
        printAlphabet.Start();

        // Thread 3
        Thread printRandomNumbers = new Thread(() => p.PrintRandomNumbers()) { Name = "Random Thread" };
        printRandomNumbers.Start();

        printAscending.Join();
        printAlphabet.Join();
        printRandomNumbers.Join();

        System.Console.WriteLine("Main method completed.");
    }
}