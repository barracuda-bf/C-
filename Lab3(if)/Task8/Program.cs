using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2,t3;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            Double a,b,c,d;
            a = Double.Parse(t1);
            b = Double.Parse(t2);
            c = Double.Parse(t3);
            if (a == 0) { Console.WriteLine("Данное уравнение не является квадратным"); return; }
            d = b*b-4*a*c;
            if (d<0) {
                Console.WriteLine("Вещественных корней уравнения 1x^2 + 2x + 3 = 0 нет"); return;
            } else if (d > 0) {
                Console.WriteLine("У уравнения 3x^2 + 17x + 5 = 0 два вещественных корня"); return;
            }
            else if (d == 0)
            {
                Console.WriteLine("Уравнение 3x^2 + 6x + 3 = 0 имеет один корень"); return;
            }
       }
    }
}
