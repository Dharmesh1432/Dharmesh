/* Write a program to call class method. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class DB
    {
        public string name = "DBMAKWANA";
        public int id = 50;
    }
    class Program
    {
        static void Main(string[] args)
        {
            DB jems = new DB();
            Console.WriteLine(jems.name);
            Console.WriteLine(jems.id);

            Console.Read();
        }
    }
}
