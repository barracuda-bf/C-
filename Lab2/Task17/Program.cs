using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b,c;
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            double x, y,S;
            x = double.Parse(a);
            y = double.Parse(b);
            S = double.Parse(c);
            double s = S / (x+y) ;
            Console.WriteLine("{0:F4}", s);
        }
    }
}
