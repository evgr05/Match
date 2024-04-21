using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match
{
    public class Circle
    {
        public static double CalculateArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным.");
            }
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус круга: ");
            double radius = double.Parse(Console.ReadLine());

            double area = Circle.CalculateArea(radius);

            Console.WriteLine($"Площадь круга с радиусом {radius} равна {area}");
        }
    }
}