using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    class Program
    {
        static void Main(string[] args)
        {
            String i1, i2, i3, i4;
            i1 = Console.ReadLine();
            i2 = Console.ReadLine();
            i3 = Console.ReadLine();
            i4 = Console.ReadLine();
            double a,b,c,d,wir;
            a = double.Parse(i1);
            b = double.Parse(i2);
            c = double.Parse(i3);
            d = double.Parse(i3);
            wir = (a*d+b*c)/a*b;
            Console.WriteLine("{0:F4}", wir);
        }
    }
}
