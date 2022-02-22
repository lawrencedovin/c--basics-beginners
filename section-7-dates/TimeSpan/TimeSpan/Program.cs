using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating
            var timeSpan1 = new TimeSpan(1, 2, 3);

            var timeSpan2 = new TimeSpan(1, 0, 0);
            var timeSpan3 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan1.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan1.TotalMinutes);

            // Add Time
            Console.WriteLine("Add Example: " + timeSpan1.Add(TimeSpan.FromMinutes(8)));

            // Subtract Time
            Console.WriteLine("Subtract Example: " + timeSpan1.Subtract(TimeSpan.FromMinutes(2)));

            // Conversion to String: ToString()
            Console.WriteLine("ToString: " + timeSpan1.ToString());

            //Conversion from a String: Parse()
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

        }
    }
}
