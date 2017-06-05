using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            String a1, b, c;
            a1 = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            double v0, t, a;
            v0 = double.Parse(a1);
            t = double.Parse(b);
            a = double.Parse(c);
            double s = v0 * t + (a * Math.Pow(t,2)) / 2;
            Console.WriteLine("{0:F1}", s);
        }
    }
}
