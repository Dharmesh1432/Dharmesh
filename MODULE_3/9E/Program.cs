/*
1
2 2
3 3 3
4 4 4 4
5 5 5 5 5       */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9E
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
                        Console.Write(i);
                    }
                    
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
