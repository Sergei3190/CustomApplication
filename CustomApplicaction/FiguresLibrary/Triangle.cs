using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    public class Triangle : Figure
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public override string Name { get; } = "Triangle";

        public Triangle(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override string ToString() => $" {nameof(Name)}: {Name}" +
                                             $" {nameof(A)} = {A}" +
                                             $" {nameof(B)} = {B}" +
                                             $" {nameof(C)} = {C}";
        public override float Area()
        {
            var halfPer = (A + B + C) / 2;

            var result = (float)(Math.Sqrt(halfPer * (halfPer - A) * (halfPer - B) * (halfPer - C)));

            return result;
        }

        public bool RightTriangle(Triangle triangle)
        {
            var flag = false;

            var res1 = triangle.A * triangle.A + triangle.B * triangle.B;

            var res2 = triangle.C * triangle.C;

            if (res1 == res2)
            {
                flag = true;
            }

            return flag;
        }
    }
}
