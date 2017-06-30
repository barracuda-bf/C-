using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nN=");
            int n = int.Parse(Console.ReadLine());
            int i = 1;

            while (i <= n)
            {
                if (i % 2 != 0)
                    Console.Write("{0} ", i);
                ++i;
            }
        }
    }
}
