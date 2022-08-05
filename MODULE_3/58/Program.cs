/* Write a program to prevent class from being instantiated. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58
{
    static class DM
    {
        static public int a = 10;
    }
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(DM.a);
            Console.Read();
        }
    }
}
