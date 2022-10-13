using System;

namespace OOP_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle small = new Circle(5);
            Circle large = new Circle(6);
            Console.WriteLine("Area of the small circle is {0}", 
                Math.Round(small.GetArea(), 2));
            Console.WriteLine("Area of the large circle is {0}", 
                Math.Round(large.GetArea(), 2));
            Console.WriteLine("Circumference of the small circle is {0}",
                Math.Round(small.GetCircumference(), 2));
            Console.WriteLine("Circumference of the large circle is {0}",
                Math.Round(large.GetCircumference(), 2));
            Console.WriteLine("The volume of a sphere with a radius of 5 is " +
                "{0}", small.GetSphereVolume());
            Triangle tri = new Triangle(3, 7);
            Console.WriteLine("Area of the triangle is {0}", tri.GetArea());
            Console.ReadKey();
        }
    }
    class Circle
    {
        float _pi = 3.141f;
        int _Radius;

        public Circle(int radius)
        {
            _Radius = radius;
        }
        public float GetArea()
        {
            return _Radius * _Radius * _pi;
        }
        public float GetCircumference()
        {
            return _pi * (_Radius * 2);
        }
        public float GetSphereVolume()
        {
            return 4 * _pi * (_Radius * _Radius * _Radius) / 3.0f;
        }
    }
    class Triangle
    {
        float Height;
        float Width;

        public Triangle(float height, float width)
        {
            Height = height;
            Width = width;
        }
        
        public float GetArea()
        {
            return Height * Width / 2;
        }
    }
}
