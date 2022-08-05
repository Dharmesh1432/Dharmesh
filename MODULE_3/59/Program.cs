/* Write a program to implement virtual method in derived class. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59
{
    abstract class Base
    {
        virtual internal void Fun()
        {
            Console.WriteLine("Hello.....This is Virtual Function");
        }
    }

    class Derived : Base
    {
        override internal void Fun()
        {
            Console.WriteLine("Hello.....\nThis is Override Function");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Derived();
            b.Fun();

            Console.Read();
        }
    }
}
