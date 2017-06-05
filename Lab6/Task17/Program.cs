using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
               
            Double x,sum = 0;
            x = Double.Parse (Console.ReadLine());
            sum = sum +x;
          
            while (x != 0 ) {
                x = Double.Parse(Console.ReadLine());
                sum = sum +x;
            }
            Console.WriteLine(sum);
            
            /* второй вариант решения
            int x;
            int sum=0;
             do {
             x = int.Parse(Console.ReadLine());
             sum +=x; // sum = sum+x;
             } while (x!=0);
             Console.WriteLine (sum);*/

        }
    }
}
