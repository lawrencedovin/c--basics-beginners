using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonPrimitiveTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Lawrence";
            person.Introduction();

            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);
            System.Console.WriteLine(result);
            
        }
    }
}
