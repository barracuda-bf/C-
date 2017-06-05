using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b;
            a = Console.ReadLine();
            b = Console.ReadLine();
            double r1, r2, c;
            r1 = double.Parse(a);
            r2 = double.Parse(b);
            c = 1 / r1 + 1 / r2;
            Console.WriteLine("{0:F4}", c);
        }
    }
}
