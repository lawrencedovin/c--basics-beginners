using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Lawrence Dovin ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            // Splitting firstName and lastName
            var spaceIndex = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, spaceIndex);
            var lastName = fullName.Substring(spaceIndex + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            // Easier way to split firstName and lastName
            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            // Replace
            var replacedName = fullName.Replace("Lawrence", "Pizza");
            Console.WriteLine(replacedName);

            // Checks if String is empty or null
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            // Numbers to Strings/ Currency
            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));

            // Strings to Numbers
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

        }
    }
}
