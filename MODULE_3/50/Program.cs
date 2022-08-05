/* Write a program to sort a numeric array without using array methods. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] DB = new int[5];
            int temp;

            Console.WriteLine("enter the element of number :");

            for (int i = 0; i < 5; i++)
            {
                DB[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("array........");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("a[{0}] :{1}", i, DB[i]);
            }

            Console.WriteLine("sorting array.......");
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (DB[i] > DB[j])
                    {
                        temp = DB[i];
                        DB[i] = DB[j];
                        DB[j] = temp;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("a[{0}] : {1}", i, DB[i]);
            }
            Console.Read();
        }
    }
}
