using System;
using System.Collections.Generic;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.Width = 24.00;
            rect1.Height = 8.00;

            Elipse elipse1 = new Elipse();
            elipse1.Width = 24.00;
            elipse1.Height = 8.00;

            object[] allTheRectangles = new object[2] { rect1, elipse1 };

            Console.WriteLine(string.Join(",", AreaCalculator.Area(allTheRectangles)));
        }
    }

    public class Elipse
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class AreaCalculator
    {
        public static List<double> Area(object[] shapes)
        {
            List<double> area = new List<double>();
            foreach (var shape in shapes)
            {
                if( shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    area.Add(rectangle.Width * rectangle.Height);
                } else
                {
                    Elipse elipse = (Elipse)shape;
                    area.Add(elipse.Width * elipse.Height * Math.PI);
                }
            }

            return area;
        }
    }
}
