/* Show ASCII value of entered number */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("enter the charcater :");
            a = Convert.ToChar(Console.ReadLine());

            int ascii = a;

            Console.WriteLine("ascii value is {0}",ascii);
            Console.Read();
        }
    }
}
