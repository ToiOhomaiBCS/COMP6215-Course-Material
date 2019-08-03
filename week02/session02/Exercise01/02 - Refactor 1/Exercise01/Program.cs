using System;
using System.Collections.Generic;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Rectangle();
            shape1.Width = 24.00;
            shape1.Height = 8.00;

            Shape square1 = new Square();
            square1.Width = 24.00;
            square1.Height = 12.00;

            Shape[] allTheRectangles = new Shape[2] { shape1, square1 };

            Console.WriteLine(string.Join("\n", AreaCalculator.Area(allTheRectangles)));
        }
    }

    public abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        //public double Width { get; set; }
        //public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }

        //public Rectangle(double w, double h)
        //{
        //    Width = w;
        //    Height = h;
        //}
    }

    public class Square : Shape
    {
        //public double Width { get; set; }
        //public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }

        //public Square()
        //{

        //}
    }

    public class AreaCalculator
    {
        public static List<double> Area(Shape[] shapes)
        {
            List<double> area = new List<double>();
            foreach (var shape in shapes)
            {
                area.Add(shape.Area());
            }

            return area;
        }
    }
}
