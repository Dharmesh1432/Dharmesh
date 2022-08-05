/*
1
1 2
1 2 3
1 2 3 4
1 2 3 4 5        */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9F
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    {
                        Console.Write(j);
                    }

                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
