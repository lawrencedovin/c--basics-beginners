using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };

            // Add to List
            numbers.Add(1);
            numbers.AddRange(new int[3] { 4, 5, 6 });

            foreach(var number in numbers)
                Console.WriteLine(number);

            // Index
            Console.WriteLine();
            Console.WriteLine(String.Format("Index of 1: " + numbers.IndexOf(1)));
            Console.WriteLine(String.Format("Last Index of 1: " + numbers.LastIndexOf(1)));

            // Count
            Console.WriteLine("Count: " + numbers.Count);

            // Remove
            for(int i = 0; i < numbers.Count; i++) 
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            Console.WriteLine("Numbers 1 Completely removed.");
            foreach (var number in numbers)
                Console.WriteLine(number);

            // Clear
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
