using System;

namespace Task2
{
    class Rectangle
    {
        private double side1;
        private double side2;
        public double Area { get; }
        public double Perimeter { get; }
        public Rectangle(double a, double b)
        {
            side1 = a;
            side2 = b;
            Area = AreaCalculator();
            Perimeter = PerimeterCalculator();
        }
        private double AreaCalculator()
        {
            return side1 * side2;
        }
        private double PerimeterCalculator()
        {
             return 2 * (side1 + side2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input height and width");
            double height = Convert.ToDouble(Console.ReadLine());
            double width = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(height, width);
            Console.WriteLine("Area: {0}, Perimeter: {1}", rectangle.Area, rectangle.Perimeter);
        }
    }
}
