using System;

namespace Factory
{
    public class Triangle : IShape
    {

        private readonly double _height;
        private readonly double _width;

        public Triangle(double h, double w)
        {
            this._height = h;
            this._width = w;
        }
        
        public void PrintInformation()
        {
            Console.WriteLine("Triangle Height: " + _height);
            Console.WriteLine("Triangle Width: " + _width);
            Console.WriteLine("Triangle Area: " + GetArea());
        }

        public double GetArea()
        {
            return (_height * _width) / 2;
        }
    }
}