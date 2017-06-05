using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task29
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1,t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            Double a,b,b1,a1,was;
            a = Double.Parse(t1);
            b = Double.Parse(t2);
            a1 = a*Math.PI/180;
            b1 = a*Math.PI/180;
            was = Math.Sin (a1)*Math.Cos(b1)+Math.Cos (a1)*Math.Sin(b1);
            Console.WriteLine("{0:F4}", was);
        }
    }
}
