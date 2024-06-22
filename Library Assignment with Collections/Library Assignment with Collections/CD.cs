using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Assignment_with_Collections
{
    internal class CD
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public int LoanPeriod
        {
            get { return 14; }
        }
        public string Borrower { get; set; }
        public void Borrow(string borrower)
        {
            if (Borrower == null)
            {
                Borrower = borrower;
                Console.WriteLine($"{Album} by {Artist} has been borrowed by {Borrower}");
            }
            else
            {
                Console.WriteLine($"{Album} by {Artist} is already borrowed by {Borrower}");
            }
        }

        public void Return()
        {
            if (Borrower != null)
            {
                Console.WriteLine($"{Album} by {Artist} has been returned");
                Borrower = null;
            }
            else
            {
                Console.WriteLine($"{Album} by {Artist} is not borrowed");
            }
        }

        public void Print()
        {
            Console.WriteLine($"CD: {Album} by {Artist} ({(Borrower == null ? "available" : "Borrowed by" + Borrower)})");
        }
    }
}
