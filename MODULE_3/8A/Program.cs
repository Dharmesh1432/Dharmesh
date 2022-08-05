/*
1+4+9+16+25+…..    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0;
            Console.WriteLine("enter the number is :");
            n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                r = n * n;
                sum = r + sum;
                n--;
            }
            Console.WriteLine("total is :{0}",sum);
            Console.Read();
        }
    }
}
