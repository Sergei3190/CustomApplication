using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    public class Circle : Figure
    {
        private const float PI = 3.14f;
        public float Radius { get; set; }
        public override string Name { get; } = "Circle";

        public Circle(float radius)
        {
            Radius = radius;
        }

        public override string ToString() => $" {nameof(Name)} = {Name}" +
                                             $" {nameof(Radius)} = {Radius}";

        public override float Area()
        {
            var result = PI * Radius * Radius;

            return result;
        }
    }
}
