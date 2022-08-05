/* Write a program to call static method using class. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37
{
    class DM
    {
        static public string name;        
    }

    class Program
    {
        static void Main(string[] args)
        {            
            DM.name = "DHARMESH";
            Console.WriteLine("name  is : " +DM.name);
            Console.Read();
        }
    }
}