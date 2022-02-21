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
            /*var person = new Person();
            person.Name = "Lawrence";
            person.Introduction();

            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);
            System.Console.WriteLine(result);*/

            /*var numbers = new int[3] { 1, 2, 3 };
            for(int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine(numbers[i]);
            }*/

            var firstName = "Lawrence";
            var middleName = "Refundo";
            var lastName = "Dovin";

            var fullName = string.Format("{0} {1}", firstName, lastName);

            var names = new string[3] {firstName, middleName, lastName};
            var formattedFullName = string.Join(" ", names);

            //System.Console.WriteLine(formattedFullName);

            var text = @"Hi John 
Look into the following paths 
c:\folder1\folder2 
c:\folder2\folder3";

            System.Console.WriteLine(text);
            
        }
    }
}
