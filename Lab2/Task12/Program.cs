using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b;
            a = Console.ReadLine();
            int T;
            T = int.Parse(a);
            double s = T * Math.PI / 180;
            double T1 = 5* Math.Cos(s);
            Console.WriteLine("{0:F4}", T1);
        }
    }
}
