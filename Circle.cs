using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb1
{
    internal class Circle
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
}
