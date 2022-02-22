using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class PasswordGenerator
    {
        public static string generatePassword()
        {
            var random = new Random();
            string password = "";
            for(int i = 0; i < 10; i++)
            {
                password += (char)('a' + random.Next(0, 26));
            }
            return password;
        }
    }
}
