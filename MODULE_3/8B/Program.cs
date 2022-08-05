/* 1+1+2+3+5+8+….. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8B
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1, c, n, i = 1;
            Console.WriteLine("enter the count of number in series");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("fibonacci.........");
            Console.WriteLine("{0}",a);
            Console.WriteLine("{0}",b);

            for (i = 1; i <= n; i++)
            {
                c = a + b;
                Console.WriteLine("{0}",c);
                a = b;
                b = c;
            }
            Console.Read();
        }
    }
}
