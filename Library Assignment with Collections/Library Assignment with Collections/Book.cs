using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Assignment_with_Collections
{
    internal class Book : ILoanable, IPrintable
    {
        public string Author { set; get; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int LoanPeriod
        {
            get { return 21; }
        }
        public string Borrower { get; set; }
        public void Borrow(string borrower)
        {
            if (Borrower == null)
            {
                Borrower = borrower;
                Console.WriteLine($"{Title} by {Author} has been borrowed by {Borrower}");
            }
            else
            {
                Console.WriteLine($"{Title} by {Author} is already borrowed by {Borrower}");
            }
        }

        public void Return()
        {
            if (Borrower != null)
            {
                Borrower = null;
                Console.WriteLine($"{Title} by {Author} has been returned");
            }
            else
            {
                Console.WriteLine($"{Title} by {Author} is not borrowed");
            }
        }

        public void Print()
        {
            Console.WriteLine($"Book: {Title} by {Author} (ISBN: {ISBN})");
        }
    }
}
