using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
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
            double T1 = Math.Sin(s);
            Console.WriteLine("{0:F4}",s);
        }
    }
}
