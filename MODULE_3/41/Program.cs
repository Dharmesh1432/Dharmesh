/* Write a program to redefine method logic in child class. (Overloading) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    class GFG
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GFG g1 = new GFG();
            int MD = g1.Add(10, 20);
            Console.WriteLine("sum is :" + MD);

            int MD1 = g1.Add(10, 30, 20);
            Console.WriteLine("3 number sum is :" + MD1);
            Console.Read();
        }
    }
}
