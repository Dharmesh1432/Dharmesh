﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40
{
    class A
    {
        public A()
        {
            Console.WriteLine("Mammals can give direct birth.");
        }
    }
    class B
    {
        public B()
        {
            Console.WriteLine("Winged animal can flap.");
        }
    }
    class Child : A, B
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
