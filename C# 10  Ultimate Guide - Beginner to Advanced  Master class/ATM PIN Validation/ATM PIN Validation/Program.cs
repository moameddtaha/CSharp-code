// See https://aka.ms/new-console-template for more information
using Card;
using System.Net.NetworkInformation;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            DebitCard card = new DebitCard();

            System.Console.WriteLine("Enter debit card pin.");
            string userPin = System.Console.ReadLine();

            card.Pin = userPin;

            System.Console.WriteLine(card.Pin);

        }
    }
}


