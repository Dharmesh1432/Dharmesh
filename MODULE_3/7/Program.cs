/* Create program to take 2 numbers from user and show maximum number */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("enter the value of a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the value of b :");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a is max");

            }
            else
            {
                Console.WriteLine("b is max");
            }
            Console.Read();
        }
    }
}
