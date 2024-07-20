using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Assignment_with_Collections
{
    internal interface ILoanable
    {
        int LoanPeriod { get; }
        string Borrower { get; set; }
        void Borrow(string borrower);
        void Return();
    }
}
