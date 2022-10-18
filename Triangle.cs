using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb1
{
    internal class Triangle
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
