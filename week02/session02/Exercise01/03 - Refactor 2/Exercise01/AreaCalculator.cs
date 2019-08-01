using System.Collections.Generic;

namespace Exercise01
{
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
