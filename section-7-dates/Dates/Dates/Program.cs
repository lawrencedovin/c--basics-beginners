using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            // Getting Information
            //Console.WriteLine("Hour: " + now.Hour);
            //Console.WriteLine("Minute: " + now.Minute);

            // Get tomorrow or yesterday at the same exact time
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            // Outputting DateTime
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm tt"));
        }
    }
}
