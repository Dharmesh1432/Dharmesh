/* Create a program to differentiate explicit and implicit conversation. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit
            int a = 75;
            long j = a;
            Console.WriteLine(j);
           
            //explicit
            double b = 77.5;
            int i;
            i = (int)b;
            Console.WriteLine(i);
            Console.ReadLine();
        }        
    }
}
