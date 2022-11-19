using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkbook
{
    internal class Program
    {
        static cCheckbook _book;
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                _book = new cCheckbook(args[0]);
            }
            else
            {
                Console.Write("Enter staring Balance: ");
                _book = new cCheckbook(Console.ReadLine());
            }
            Console.WriteLine($"Starting new Checkbook with a balance of {_book}.");
            while (_book.WritingChecks)
            {
                Console.Write("Enter Check Amount: ");
                decimal amount;
                while (!decimal.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Illegal Amount.");
                    Console.Write("Enter Check Amount: ");
                }
                _book.WriteCheck(amount);
                _book.WriteBalance();
            }
        }
    }
}
