using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class Loops
    {
        public static void ForLoop(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) 
                {
                    Console.WriteLine(String.Format("{0} is even!", numbers[i]));
                } 
                else
                {
                    Console.WriteLine(String.Format("{0} is odd!", numbers[i]));
                }
            }
        }

        public static void ForEach(string name)
        {
            foreach(char letter in name) {
                Console.WriteLine(letter);
            }
        }

        public static void WhileLoop()
        {

            string choice = "y";

            while(choice == "y")
            {
                Console.WriteLine("Type your name > ");
                string name = Console.ReadLine();
                Console.WriteLine(String.Format("Your name is: " + name));
                Console.WriteLine(@"Want to Continue? 'y' for yes 'n' for no > ");
                choice = Console.ReadLine().ToLower();

                if(choice == "y")
                {
                    continue;
                }
                else if(choice == "n")
                {
                    break;
                }
                else
                {
                    while (choice != "y")
                    {
                        Console.WriteLine(@"Incorrect input, Want to Continue? 'y' for yes 'n' for no > ");
                        choice = Console.ReadLine().ToLower();

                        if(choice == "n")
                        {
                            break;
                        }
                    }
                }
            }
        }

        public static void DoWhileLoop(int[] numbers)
        {
            int i = 0;
            do
            {
                Console.WriteLine(numbers[i]);
                i++;
            }
            while (i < numbers.Length);
        }
    }
}
