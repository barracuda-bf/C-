using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            String i1, i2, i3;
            i1 = Console.ReadLine();
            i2 = Console.ReadLine();
            i3 = Console.ReadLine();
            double a, b, c;
            a = double.Parse(i1);
            b = double.Parse(i2);
            c = double.Parse(i3);
            double c1 = c * Math.PI / 180; ;
            double wir = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)-2*a*b*Math.Cos(c1));
            Console.WriteLine("0:F4", wir);
        }
    }
}
