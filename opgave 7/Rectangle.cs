namespace opgave_7
{
    internal class Rectangle
    {
        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            Width = width;  // Use property for validation
            Height = height; // Use property for validation
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Area()
        {
            return width * height;
        }
        public double Perimeter()
        {
            return (width + height) * 2;
        }
    }
}
