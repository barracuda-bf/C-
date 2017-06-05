using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            Double R, A,s1,s2;
            R = Double.Parse(t1);
            A = Double.Parse(t2);
            if (R < 0) { Console.WriteLine("Значение R должно быть неотрицательным"); return; }
            if (A < 0) { Console.WriteLine("Значение A должно быть неотрицательным"); return; }
            if (3.14 * Math.Pow(R, 2) > Math.Pow(A, 2)) {
                Console.WriteLine("Площадь круга больше площади квадрата");
            } else {
                Console.WriteLine ("Площадь квадрата больше площади круга");
            }
             
        }
    }
}
