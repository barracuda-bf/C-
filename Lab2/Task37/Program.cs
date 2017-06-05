using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task37
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
            Double V1, T1, V2, T2,V,T;
            V1 = Double.Parse(t1);
            T1 = Double.Parse(t2);
            V2 = Double.Parse(t3);
            T2 = Double.Parse(t4);
            V = V1 + V2;
            T = (T1 * V1 + T2 * V2) / V;
            Console.WriteLine(V);
            Console.WriteLine("{0:F4}", T);
        }
    }
}
