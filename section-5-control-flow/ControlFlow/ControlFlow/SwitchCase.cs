using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class SwitchCase
    {
        public static string printSeason(Program.Season season)
        {
            switch (season)
            {
                case Program.Season.Spring:
                    return "It is Spring!";
                    break;
                case Program.Season.Summer:
                    return "It is Summer!";
                    break;
                case Program.Season.Autumn:
                    return "It is Autumn!";
                    break;
                case Program.Season.Winter:
                    return "It is Winter!";
                    break;
                default:
                    return "Incorrect Season";
            }
        }
}
}
