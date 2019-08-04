using System;

namespace Exercise01
{
    public class Elipse : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area()
        {
            return Width * Height * Math.PI;
        }

        public Elipse(double w, double h)
        {
            Width = w;
            Height = h;
        }
    }
}
