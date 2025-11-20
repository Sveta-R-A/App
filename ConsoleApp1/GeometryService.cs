using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GeometryService
    {
        public double TriangleArea(double a, double h)
        {
            if (a <= 0 || h <= 0)
                throw new ArgumentException("Сторона і висота повинні бути додатними.");

            return (a * h) / 2;
        }


        public double RectangleDiagonal(double a, double b)
        {
            if (a <= 0 || b <= 0)
                throw new ArgumentException("Сторони повинні бути додатними.");

            return Math.Sqrt(a * a + b * b);
        }
    }
}
