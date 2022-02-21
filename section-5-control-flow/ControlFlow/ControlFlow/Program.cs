using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            // Conditional Statements
            /*
            Console.WriteLine(IfElse.checkHour(10));
            Console.WriteLine(TernaryOperator.checkPrice(true));
            Console.WriteLine(SwitchCase.printSeason(Season.Autumn));
            */

            // Loops
            var numArr = new int[5] { 1, 2, 3, 4, 5 };
            var numArr2 = new int[5] { 10, 6, 4, 2, 21 };

            //Loops.ForLoop(numArr);
            //Loops.ForEach("Lawrence");
            Loops.WhileLoop();
            //Loops.DoWhileLoop(numArr2);
        }
    }
}
