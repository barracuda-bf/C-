using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task38_Lab6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Double t = Double.Parse(Console.ReadLine());
            Double t2 = Double.Parse(Console.ReadLine());
            int i = 0;
            if (t < t2)
            {

                while (t <= t2)
                {
                    if (t % 2 != 0)
                    {
                        if (i > 0)
                        {
                            Console.Write(", ");
                        }
                        Console.Write(t);

                        i++;
                    }
                    t++;
                }
            }
            else
            {
               
                while (t >= t2)
                {
                    if (t % 2 != 0)
                    {
                        if (i > 0)
                        {
                            Console.Write(", ");
                        }
                        Console.Write(t);
                        i++;
                    }
                    t--;
                }
            }
        }
    }
}

