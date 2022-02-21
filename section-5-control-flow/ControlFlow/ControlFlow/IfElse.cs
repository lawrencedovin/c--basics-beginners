using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class IfElse
    {
        public static string checkHour(int hour)
        {
            if (hour > 0 && hour < 12)
            {
                return "It's morning.";
            }
            else if (hour >= 12 && hour < 18)
            {
                return "It's afternoon.";
            }
            else
            {
                return "It's evening.";
            }
        }
    }
}