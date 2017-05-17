using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            String i, i1,i2,i3;
            i = Console.ReadLine();
            i1 = Console.ReadLine();
            i2 = Console.ReadLine();
            i3 = Console.ReadLine();
            double a, a1,a2; // переменная для дробного числа
            a = Double.Parse(i); // преобразовывает текс в число
            a1 = Double.Parse(i1);
            a2 = Double.Parse(i2);
            Console.WriteLine("<circle cx=\"\""+a+"\"cy=\""+a1+"\"\nr=\""+a2+"\"fill=\""+i3+"\"/>");
        }
    }
}
