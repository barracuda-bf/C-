using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task35
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            Double xz, xx, x1, x2, was;
            zx = Double.Parse(t1);
            xx = Double.Parse(t2);
            x1 = zx * Math.PI / 180;
            x2 = xx * Math.PI / 180;
            was = Math.Sqrt (Math.Pow (x2,2)+Math.Pow (x1,2));
            Console.WriteLine("{0:F4}", was);
        }
    }
}
