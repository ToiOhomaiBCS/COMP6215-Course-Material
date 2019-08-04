namespace Exercise01
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area()
        {
            return Width * Height;
        }

        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
        }
    }
}
