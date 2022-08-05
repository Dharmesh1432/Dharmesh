/* Get 5 values from user and show maximum value from array */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53
{
    class Program
    {
        static void Main(string[] args)
        {            
            {
                int[] DM = new int[5];
                int max , min ;
                Console.WriteLine("enter the element of number :");

                for (int i = 0; i < 5; i++)
                {
                    DM[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("array........");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("a[{0}] :{1}", i, DM[i]);
                }
                max = DM[0];
                min = DM[0];

                for (int i = 0; i < 5; i++)
                {
                    if (DM[i] > max)
                    {
                        max = DM[i];
                    }
                    if (DM[i] < min)
                    {
                        min = DM[i];
                    }
                }                   
                
                Console.WriteLine("the min value is : {0}", min);
                Console.WriteLine("the max value is : {0}", max);
                Console.Read();
            }
        }
    }
}
