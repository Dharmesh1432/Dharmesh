/*
        1
        23
        456
        78910     */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9A
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, c = 1;
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0}",c);
                    c = c + 1;
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
