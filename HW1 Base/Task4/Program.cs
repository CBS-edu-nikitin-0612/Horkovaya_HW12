using System;

namespace Task4
{
    class Figure
    {
        private Point p1;
        private Point p2;
        private Point p3;
        private Point p4 = null;
        private Point p5 = null;
        private int pointAmount;
        private double perimeter;
        private string figureName;
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }
        public Figure(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            pointAmount = 3;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            pointAmount = 4;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            pointAmount = 5;
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
        public void PerimeterCalculator()
        {
            if(pointAmount == 3)
            {
                perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p1);
            }
            else if (pointAmount == 4)
            {
                perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p1);
            }
            else if (pointAmount == 5)
            {
                perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p5) + LengthSide(p5, p1);
            }
        }
        public void FigureName()
        {
            int minSidesAmount = 3;
            if (p4 != null)
            {
                minSidesAmount += 1;
            }
            if (p5 != null)
            {
                minSidesAmount += 1;
            }
            switch (minSidesAmount)
            {
                case 3: Console.WriteLine("Треугольник");
                    break;
                case 4:
                    Console.WriteLine("Четырехугольник");
                    break;
                case 5:
                    Console.WriteLine("Пятиугольник");
                    break;
            }
        }
        public string ShowFigureName()
        {
            return figureName;
        }
    }
    class Point 
    {
        private int x;
        private int y;
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public Point(int coord1, int coord2)
        {
            x = coord1;
            y = coord2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(1,3), new Point(5,7), new Point(2,5), new Point(1,4));
            figure.PerimeterCalculator();
            figure.FigureName();
            figure.ShowFigureName();
            Console.WriteLine("P = {0}", figure.Perimeter);
        }
    }
}