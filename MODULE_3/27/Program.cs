/* Create program to replace specific word from string */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Good Eorning";
            Console.WriteLine(name.Replace('E', 'M'));
            Console.Read();
        }
    }
}
