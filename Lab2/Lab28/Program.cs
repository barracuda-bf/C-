using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab28
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1,t2,t3,t4;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            t4 = Console.ReadLine();
            Double a,b,c,x,was;
            a = Double.Parse(t1);
            b = Double.Parse(t2);
            c = Double.Parse(t3);
            x = Double.Parse(t4);
            if ((a < 0)||(b < 0)||(c < 0)||(x < 0)) {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            if ((a == 0)||(b == 0)||(c == 0)||(x == 0)) {
            Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            was = 1 / Math.Sqrt(a*Math.Pow (x,2)+b*x+c);
            Console.WriteLine ("{0:F4}",was);
        }
    }
}
