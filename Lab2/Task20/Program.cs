using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            String a1, b, c;
            a1 = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            double m,v,h;
            m = double.Parse(a1);
            v = double.Parse(b);
            h = double.Parse(c);
            double g = 9.8067;
            double T = m * Math.Pow(v, 2) / 2;
            double Wn = m * g * h;
            Console.WriteLine("{0:F1}", T);
            Console.WriteLine("{0:F1}", Wn);
        }
    }
}
