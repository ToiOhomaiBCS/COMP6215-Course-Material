using System;
using System.Collections.Generic;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
            {
                new Rectangle(24.00, 8.00),
                new Rectangle(36.00, 9.00),
                new Elipse(12.00, 12.00)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Area());
            }
        }
    }
}
