using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task34
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            Double a, b, b1, a1, was;
            a = Double.Parse(t1);
            b = Double.Parse(t2);
            a1 = a * Math.PI / 180;
            b1 = a * Math.PI / 180;
            was = 3*Math.Sin(2*a1) * Math.Cos(3*b1);
            Console.WriteLine("{0:F4}", was);
        }
    }
}
