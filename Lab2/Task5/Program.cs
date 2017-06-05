using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            double x;
            x = double.Parse(a);
            double s = 4 * Math.PI * Math.Pow (x,3)/3;
            Console.WriteLine("{0:F4}",s);
        }
    }
}
