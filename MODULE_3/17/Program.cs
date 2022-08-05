/* Write a program to calculate arithmetic operations using class and object. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class arithmatic
    {
        private int a;
        private int b;

        public void setdata(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Add()
        {
            Console.WriteLine("addition is {0}", a + b);
        }
        public void Sub()
        {
            Console.WriteLine("subtraction is {0}", a - b);
        }
        public void Mul()
        {
            Console.WriteLine("multipication is {0}", a * b);
        }
        public void Div()
        {
            Console.WriteLine("divsion is {0}", a / b);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            arithmatic a1 = new arithmatic();
            a1.setdata(10, 2);

            a1.Add();
            a1.Div();
            a1.Mul();
            a1.Sub();

            Console.Read();
        }
    }
}
