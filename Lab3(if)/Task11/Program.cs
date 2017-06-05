using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2,t3;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            Double a,b,c;
            a = Double.Parse(t1);
            b = Double.Parse(t2);
            c = Double.Parse(t2);
            if ((a < b) && (b < c)) {
                Console.WriteLine("Выполняется");
            } else {
                Console.WriteLine("\"Не выполняется\""); 
            }
           
        }
    }
}
