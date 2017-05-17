using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            String i,i1;
            i = Console.ReadLine();
            i1 = Console.ReadLine();
            double a,a1; // переменная для дробного числа
            a = Double.Parse(i); // преобразовывает текс в число
            a1 = Double.Parse(i1);
            Console.WriteLine("INSERT INTO points (x, y) VALUES ('"+a+"'","'"+a1+"'");
        }
    }
}
