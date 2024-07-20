using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Assignment_with_Collections
{
    internal class Library
    {
        private List<ILoanable> loanableItems;

        public Library()
        {
            loanableItems = new List<ILoanable>();
        }

        public void AddItem(ILoanable item)
        {
            loanableItems.Add(item);
        }

        public void RemoveItem(ILoanable item)
        {
            loanableItems.Remove(item);
        }

        public void PrintInventory()
        {
            try
            {
                Console.WriteLine("\n Library inventory");
                foreach (IPrintable item in loanableItems)
                {
                    item.Print();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void BorrowedItem(ILoanable item, string borrower)
        {
            item.Borrow(borrower);
        }
        public void RerturnItem(ILoanable item)
        {
            item.Return();
        }
    }
}
