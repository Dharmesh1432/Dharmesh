/* Create a program to store student’s details using Dictionary */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> disc = new Dictionary<string, object>();
            disc.Add("ID", 1);
            disc.Add("name", "Vivek");
            disc.Add("email", "v@gmail.com");
            disc.Add("salary", 50000);
            disc.Add("gender", 'm');

            foreach (var item in disc)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            Console.Read();
        }
    }
}
