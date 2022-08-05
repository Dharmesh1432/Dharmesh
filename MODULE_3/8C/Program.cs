/* 1 + 5 + 14 + 30 + 55 +….. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8C
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("N : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i * i;
                Console.Write(sum);
            }
            Console.Read();
        }
    }
}
