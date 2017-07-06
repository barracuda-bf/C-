using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Lab02
    {
        public static double task4411(double x)
        {
            double r;
            r = x + 7;
            return r;
        }

        public static double task8428(double aInGrad)
        {
            double r;
            r = aInGrad * Math.PI / 180;
            return r;
        }
        
        public static double task1262(double aInGrad)
        {
            double r,t;
            t = aInGrad * Math.PI / 180;
            r = 5*Math.Cos(t);
            return r;
        }
        public static double task2790(double aInGrad)
        {
            double r, t;
            t = aInGrad * Math.PI / 180;
            r = Math.Sqrt (1-Math.Pow(Math.Sin(t),2));
            return r;
        }
        public static double task9164(double a,double b)
        {
            double r, x, y;
            x = a * Math.PI / 180;
            y = b * Math.PI / 180;
            r = Math.Sin(x) * Math.Cos(y) + Math.Cos(x) * Math.Sin(y);
            return r;
        }
        public static double task5789(double Xa, double Ya,double Xb,double Yb)
        {
            double r, x, y;
            r = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2));
            return r;
        }
        public static double task5789(double a, double b, double c)
        {
            double r, a,b,c;
            r = a*x*x+b*x+c=0;
            return r;
        }
    }
}
