/* Create program to make transform of two matrices */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int[,] DM = new int[50, 50];
            Console.WriteLine("array matrix.....");

            Console.WriteLine("enter the row of number is:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the colum of number is:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter  element...");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    DM[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("show  element...");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(" " + DM[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("transpose matrix..");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(" " + DM[j, i]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
