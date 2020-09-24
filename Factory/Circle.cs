using System;

namespace Factory
{
    public class Circle : IShape
    {

        private readonly double _r;
        private readonly double _d;

        public Circle(double r)
        {
            this._r = r;
        }
        
        public Circle(double r, double d)
        {
            this._r = r;
            this._d = d;
        }
        
        public void PrintInformation()
        {
            Console.WriteLine("Circle Radius: " + _r);
            Console.WriteLine("Circle Diameter: " + _d);
            Console.WriteLine("Circle Area: " + GetArea());
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_r, 2);
        }
    }
}