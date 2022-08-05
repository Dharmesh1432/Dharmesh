/*Create program to replace specific character from string*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "hello guys goodmorning";
            Console.WriteLine(name.Replace("guys", "boys"));
            Console.Read();
        }
    }
}
