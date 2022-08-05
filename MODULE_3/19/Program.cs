/* Write a program to get three subject marks details and then show average and sum. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            int maths = 50, guj = 60, eng = 75, sum;
            float avg;

            sum = maths + guj + eng;
            avg = (float)sum / 3;
            Console.WriteLine("sum is {0}",sum);
            Console.WriteLine("avg is {0}",avg);

            Console.Read();
        }
    }
}
