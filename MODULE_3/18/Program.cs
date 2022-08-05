/* Write a program to call method of parent class. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Parent
    {
        protected int x, y;
        internal void SetValue()
        {
            x = 20;
            y = 10;
            Console.WriteLine("This Is Parent Class Calling ...........");
            Console.WriteLine("Value of X : {0}", x);
            Console.WriteLine("Value of Y : {0}", y);
        }

    }

    class Child : Parent
    {
        internal void Display()
        {
            Console.WriteLine("This Is From Child Class.......");
            Console.WriteLine("Addition Of Values {0} + {1} : {2}", x, y, x + y);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.SetValue();
            c.Display();

            Console.Read();
        }
    }
}
