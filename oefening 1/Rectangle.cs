using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening_1
{
    internal class Rectangle
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public double CalculateArea()
        {
            return Width * Height;
        }
        public double CalculatePerimeter()
        {
            return (Width * 2) + (Height * 2);
        }
    }
}
