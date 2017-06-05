using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task31
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1;
            t1 = Console.ReadLine();
            Double x, was;
            x = Double.Parse(t1);
            was = 7 * Math.Pow(x, 2) - 3 * x + 6;
            Console.WriteLine("{0:F4}", was);
        }
    }
}
