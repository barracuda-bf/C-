using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            Double V1, V2;
            V1 = Double.Parse(t1);
            V2 = Double.Parse(t2);
            if (V1 *1000*3600 < V2) {
                Console.WriteLine("V1 (км/ч) меньше V2 (м/с)");
            } else {
                Console.WriteLine("V2 (м/с) меньше V1(км/ч)"); 
            }
        }
    }
}
