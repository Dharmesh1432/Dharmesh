/* . Create program to take 3 numbers from user and show maximum and minimum number */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, Max, Min;
            Console.WriteLine("enter the x is :");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the y is :");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the z is :");
            z = Convert.ToInt32(Console.ReadLine());

            Max = (x < y ? (y < z ? z : y) : (x < z ? z : x));
            Console.WriteLine("Maximum number is {0}:",Max);

            Min = (x > y ? (y > z ? z : y) : (x > z ? z : x));
            Console.WriteLine("Minimum number is {0}:", Min);
            Console.Read();
        }
    }
}
