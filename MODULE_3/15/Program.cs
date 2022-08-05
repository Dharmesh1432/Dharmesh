/* Create program to iterate string variable using foreach loop */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            li.Add("jaimin");
            li.Add("vivek");
            li.Add("sunil");
            li.Add("vishal");
            li.Add("abhi");

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
