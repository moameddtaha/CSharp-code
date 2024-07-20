using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasks
{

    public class UpCounter
    {
        public void CountUp(int count)
        {
            System.Console.WriteLine("\nCount Up starts");
            for (int i = 1; i <= count; i++)
            {
                System.Console.WriteLine($"{i}, ");
            }
            System.Console.WriteLine("\nCount Up ends");
        }
    }

    public class DownCounter
    {
        public void CountDown(int count)
        {
            System.Console.WriteLine("\nCount Down starts");
            for (int j = count; j >= 1; j--)
            {
                System.Console.WriteLine($"{j}, ");
            }
            System.Console.WriteLine("\nCount Down ends");
        }
    }

    public class Program1
    {
        public static void Main()
        {
            
        }
    }
}