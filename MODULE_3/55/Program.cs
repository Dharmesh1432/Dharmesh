/* Write a program of abstract class with implemented methods and declared methods. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55
{
    abstract class Base
    {
        int r;
        virtual internal void Set()
        {
            r = 20;
            Console.WriteLine("Value Of R : ");
        }
        virtual internal void Shows()
        {

        }

    }

    class Derived : Base
    {
        int r;

        override internal void Set()
        {
            Console.Write("Enter Circle Radius : ");
            r = Convert.ToInt32(Console.ReadLine());
        }

        override internal void Shows()
        {
            Console.WriteLine("Area Of Circle : {0}", 3.14 * r * r);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Derived();
            b.Set();
            b.Shows();

            Console.Read();
        }
    }
}
