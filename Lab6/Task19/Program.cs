using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x, sum = 0, i = 0;
            x = Double.Parse(Console.ReadLine());
            sum = sum + x;
            do {
                x = int.Parse(Console.ReadLine());
                sum += x; // sum = sum+x;
            } while ((sum>83)||(sum<199));
            

            Console.WriteLine(sum); // выражение не верно нужно исправить добавить 2 переменные лево и право и 
            Console.WriteLine("Сумма слева: "+___", сумма справа: "+_______);
        }
    }
}
