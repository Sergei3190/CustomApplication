using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresLibrary;

namespace CustomApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Figure> figures = new List<Figure>
                {
                    new Circle (12),
                    new Triangle (10, 4.4f, 8),
                    new Circle (12),
                    new Triangle (3, 4, 5)
                };

                foreach (var item in figures)
                {
                    var area = item.Area();

                    if (item is Circle circle)
                    {
                        Console.WriteLine($"Area circle by name {circle.Name} equals {area:f2}");
                    }

                    if (item is Triangle triangle)
                    {
                        Console.WriteLine($"Area triangle by name {triangle.Name} equals {area:f2}");

                        var rightTriangle = triangle.RightTriangle(triangle);

                        if (rightTriangle)
                        {
                            Console.WriteLine($"The triangle by name {triangle.Name} is rectangular");
                        }
                        else
                        {
                            Console.WriteLine($"The triangle by name {triangle.Name} is not rectangular");
                        }
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }

            Console.ReadLine();
        }
    }
}
