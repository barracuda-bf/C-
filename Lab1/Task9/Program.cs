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
            String i;
            i = Console.ReadLine();
            //double a; // переменная для дробного числа
            //a = Double.Parse(i); // преобразовывает текс в число
            Console.WriteLine("SELECT first_name, last_name, group\nFROM students WHERE student_id = '"+i+"'"); // вывод информации в кавычках
           
        }
    }
}
