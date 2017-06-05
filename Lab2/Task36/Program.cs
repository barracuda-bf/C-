using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task36
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3, t4;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            t4 = Console.ReadLine();
            Double Xa,Ya,Xb,Yb, was;
            Xa = Double.Parse(t1);
            Ya = Double.Parse(t2);
            Xb = Double.Parse(t3);
            Yb = Double.Parse(t4);
            was = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2));
            Console.WriteLine("{0:F4}", was);
        }
    }
}
