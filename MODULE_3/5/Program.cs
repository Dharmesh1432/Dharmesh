/* Create program to sort string in descending order */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "A", "Z", "R", "D", "B" };

            Array.Sort(arr);

            foreach (string item in arr)
            {
                Console.Write(item );
            }
            Console.Read();
        }
    }
}
