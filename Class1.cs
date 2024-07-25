using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public static class Geometry
    {
        public static double CircleArea(double radius)
        {
            if (radius < 0) Console.WriteLine("Значение должно быть больше 0");
            return Math.PI * radius * radius;
        }
        public static double TriangleArea(double a, double b, double c)
        {
            if ((a < 0) || (b < 0) || (c < 0)) Console.WriteLine("Значения должно быть больше 0");
            if (a + b <= c || a + c <= b || b + c <= a) Console.WriteLine("При таких значениях треугольник не получится");
            double P = (a + b + c) / 2;
            return Math.Sqrt(P*(P-a)*(P-b)*(P-c));
        }
    }
}
