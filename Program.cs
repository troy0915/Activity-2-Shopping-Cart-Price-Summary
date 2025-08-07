using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2Shopping_Cart_Price_Summary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> prices = new List<decimal>();
            decimal inputPrice;

            Console.WriteLine("Enter item prices (enter -1 to finish):");
            while (true)
            {
                Console.Write("Enter price: ");
                string input = Console.ReadLine();
                if (!decimal.TryParse(input, out inputPrice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                    continue;
                }
                if (inputPrice == -1)
                {
                    break;
                }
                if (inputPrice < 0)
                {
                    Console.WriteLine("Negative prices are not allowed (except -1 to exit).");
                    continue;
                }
                prices.Add(inputPrice);
            }
            if (prices.Count > 0)
            {
                Console.WriteLine("\nResults:");
                Console.WriteLine($"Total items: {prices.Count}");
                Console.WriteLine($"Average price: {prices.Average():C2}");
                Console.WriteLine($"Highest price: {prices.Max():C2}");
                Console.WriteLine($"Lowest price: {prices.Min():C2}");
            }
            else
            {
                Console.WriteLine("\nNo prices were entered.");
            }
        }
    }
}





