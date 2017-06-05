using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            String i1,i2,i3;
            i1 = Console.ReadLine();
            i2 = Console.ReadLine();
            i3 = Console.ReadLine();
            double a,b,c,d;
            a = double.Parse(i1);
            b = double.Parse(i2);
            c = double.Parse(i3);
            d = Math.Pow (b,2) - 4*a*c;
            Console.WriteLine("{0:F4}",d);
        }
    }
}
