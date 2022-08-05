/* Write a program to perform an example of data hiding. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class A
    {
        virtual internal void GetData()
        {

        }
    }

    class B : A
    {
        int a, b;
        override internal void GetData()
        {
            a = 10;
            b = 25;
            Console.WriteLine("Addition of {0} + {1} : {2}", a, b, a + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.GetData();

            Console.Read();
        }
    }
}
