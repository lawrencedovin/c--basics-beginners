using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypesExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Types
            byte number = 4;
            int count = 10;
            float price = 20.24f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = true;
            Console.WriteLine(number.ToString());

            // Type Casting
            byte b = 1;
            int i = b;
            string numberString = "345";
            int numberToString = Convert.ToInt32(numberString);

            // Operators
            int a = 10;
            int c = 3;
            Console.WriteLine((float)a / (float)c);
        }
    }
}
