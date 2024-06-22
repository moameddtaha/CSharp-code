namespace Library_Assignment_with_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book
            {
                Author = "J.K. Rowling",
                Title = "Harry Potter and the Philosopher's Stone",
                ISBN = "9780747532743"
            };
            Book book2 = new Book
            {
                Author = "George R.R. Martin",
                Title = "A Game of Thrones",
                ISBN = "9780553573404"
            };

            library.AddItem(book1);
            library.AddItem(book2);

            library.PrintInventory();

            Console.WriteLine();

            library.BorrowedItem(book1, "John Smith");

            library.PrintInventory();

            Console.WriteLine();

            library.RerturnItem(book1);

            library.PrintInventory();
            

            library.RemoveItem(book2);

            library.PrintInventory();
        }
    }
}
