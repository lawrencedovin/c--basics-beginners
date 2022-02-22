using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class Exercises
    {
        public static List<int> divisibleBy3Between1And100()
        {
            List<int> divisibleBy3 = new List<int>();

            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    divisibleBy3.Add(i);
                }
            }

            return divisibleBy3;
        }
    }
}
