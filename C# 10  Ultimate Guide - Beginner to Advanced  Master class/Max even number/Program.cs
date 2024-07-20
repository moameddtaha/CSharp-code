using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string even = System.Console.ReadLine();

            int maxEven = 0;
            
            foreach (var n in even)
            {
                if(int.Parse(n.ToString()) % 2 == 0 && int.Parse(n.ToString()) > maxEven)
                {
                    maxEven = int.Parse(n.ToString());
                }
            }
            System.Console.WriteLine(maxEven);
        }
    }
}
