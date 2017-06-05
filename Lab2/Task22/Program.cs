using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            String i,i1;
            i = Console.ReadLine();
            i1 = Console.ReadLine();
            double m,a,c,d,g;
            g=9.8067;
            m = double.Parse(i);
            a = double.Parse(i1);
            c = a* Math.PI/180;
            d = m*g*Math.Cos(c);
            Console.WriteLine("{0:F4}", d);
        }
    }
}
