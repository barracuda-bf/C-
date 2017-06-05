using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b, c;
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            double x1, x2, x3;
            x1 = double.Parse(a);
            x2 = double.Parse(b);
            x3 = double.Parse(c);
            double s = x1*x2 + x1*x3 + x2*x3;
            Console.WriteLine("{0:F4}", s);
        }
    }
}
 //x1x2+x1x3+x2x3