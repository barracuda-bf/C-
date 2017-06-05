using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            Double Sc,Ss, c, d;
            Sc = Double.Parse(t1);
            Ss = Double.Parse(t2);
            c = Math.Sqrt (Ss);
            d = Sc / Math.PI;
            if (d < c / 2) {
                Console.WriteLine("Круг уместится в квадрате"); return;
            }  else { Console.WriteLine("Круг не поместится в квадрате"); }
        }
    }
}
