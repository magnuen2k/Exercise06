using System;

namespace Factory
{
    public class Rectangle : IShape
    {

        private readonly double _length;
        private readonly double _width;

        public Rectangle(double l, double w)
        {
            this._length = l;
            this._width = w;
        }
        
        public void PrintInformation()
        {
            Console.WriteLine("Rectangle Length: " + _length);
            Console.WriteLine("Rectangle Width: " + _width);
            Console.WriteLine("Rectangle Area: " + GetArea());
        }

        public double GetArea()
        {
            return _length * _width;
        }
    }
}