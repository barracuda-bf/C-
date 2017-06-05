using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            String i1, i2, i3,i4;
            i1 = Console.ReadLine();
            i2 = Console.ReadLine();
            i3 = Console.ReadLine();
            i4 = Console.ReadLine();
            double y, m1, m2, r, wir;
            y= double.Parse(i1);
            m1 = double.Parse(i2);
            m2 = double.Parse(i3);
            r = double.Parse(i3);
            wir = y*(m1*m2/Math.Pow(r, 2));
            Console.WriteLine("{0:F4}",wir);
        }
    }
}
