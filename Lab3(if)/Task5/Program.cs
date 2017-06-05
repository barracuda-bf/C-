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
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            Double L,P;
            L = Double.Parse(t1);
            P = Double.Parse(t2);
            if (L < 0) { Console.WriteLine("Значение L должно быть неотрицательным"); return; }
            else if (P < 0) { Console.WriteLine("Значение P должно быть неотрицательным"); return; }
            if (L * 1000 < P * 0.305)
            {
                Console.WriteLine("Расстояние в километрах меньше");
            }
            else
            {
                Console.WriteLine("Расстояние в футах меньше");
            }
        }
    }
}
