using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tas33
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1;
            t1 = Console.ReadLine();

            Double h,S,r ;
            h = Double.Parse(t1);
            r = 6350;
            if (h < 0) { Console.WriteLine("Высота над уровнем Земли должна быть неотрицательна"); }
            S = Math.Sqrt((r + h) * (r + h) - r * r);
            Console.WriteLine("{0:F4}", S);
        }
    }
}
