/* Explain 5 method of array class with example */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] DM = new char[] { 'A', 'K', 'I', 'B', 'D' };

            //Array.Sort(jdvasoya);
            //foreach (char sorting in jdvasoya)
            //{
            //    Console.WriteLine(sorting + " ");
            //}

            //Array.Reverse(jdvasoya);
            //foreach (char rev in jdvasoya)
            //{
            //    Console.WriteLine(rev + " ");
            //}

            Array.BinarySearch(DM, 4);
            foreach (char se in DM)
            {
                Console.WriteLine(se + " ");
            }
            Console.Read();
        }
    }
}
