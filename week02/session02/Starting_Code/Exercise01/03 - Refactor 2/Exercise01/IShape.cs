using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01
{
    interface IShape
    {
        double Width { get; set;}
        double Height { get; set; }
        double Area();
    }
}
