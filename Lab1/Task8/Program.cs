using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            String i;
            i = Console.ReadLine();
            double a; // переменная для дробного числа
            a = Double.Parse(i); // преобразовывает текс в число
            Console.WriteLine("\""+a+"\""); // вывод информации в кавычках
            Console.WriteLine("\"{0}\"", a); // вывод информации в кавычках с объявлением номера выводимого числа
        }
    }
}
