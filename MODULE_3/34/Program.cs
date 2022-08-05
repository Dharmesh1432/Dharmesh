/* Get 5 values from user and store in array and show all elements and sum of elements */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] DM = new int[5];

            int sum = 0;

            Console.WriteLine("enter the element of array:");
            for (int i = 0; i < DM.Length; i++)
            {
                DM[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("element is :...");
            for (int i = 0; i < DM.Length; i++)
            {
                Console.WriteLine("a[{0}] is :{1}", i, DM[i]);
            }

            Console.WriteLine("sum is ....");
            for (int i = 0; i < DM.Length; i++)
            {
                sum = sum + DM[i];
            }
            Console.WriteLine("sum : " + sum);
            Console.Read();
        }
    }
}
