using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = s1.Substring(0, 1) + s1.Substring(s1.Length - 1, 1);
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
