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
         String i;
            i = Console.ReadLine();
            double a; // переменная для дробного числа
            a = Double.Parse (i); // преобразовывает текс в число
            Console.WriteLine ("{0:F4}",a);

            Console.WriteLine("{1} {0}", 3, 7); // вывод последовательной или не последовательной информации
        }
    }
}
