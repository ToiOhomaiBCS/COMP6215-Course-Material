using System;
using System.Collections.Generic;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uncomment below when you are using constructors

            //List<object> rectangles = new List<object>
            //{
            //    new Rectangle(24.00, 8.00),
            //    new Rectangle(36.00, 9.00),
            //    new Elipse(12.00, 12.00)
            //};

            //foreach (var shape in rectangles)
            //{
            //    if (shape is Rectangle)
            //    {
            //        Rectangle rectangle = (Rectangle)shape;
            //        Console.WriteLine(rectangle.Area());
            //    }
            //    else
            //    {
            //        Elipse elipse = (Elipse)shape;
            //        Console.WriteLine(elipse.Area());
            //    }
            //}

            //Comment out below when you are using constructors

            Rectangle rect1 = new Rectangle();
            rect1.Width = 24.00;
            rect1.Height = 8.00;

            Elipse elipse1 = new Elipse();
            elipse1.Width = 24.00;
            elipse1.Height = 8.00;

            Shape[] allTheRectangles = new Shape[2] { rect1, elipse1 };

            Console.WriteLine(string.Join(",", AreaCalculator.Area(allTheRectangles)));
        }
    }

    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Elipse : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height * Math.PI;
        }

        //public Elipse(double w, double h)
        //{
        //    Width = w;
        //    Height = h;
        //}
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
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
