using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.SortableShapes;

namespace TestTask.RailFenceCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = 1.1234D;
            var radius = 1.1234D;
            var width = 5D;
            var height = 2D;
            var shapes = new List<Shape>{ new Triangle(width, height),
                new Square(side),
                new Circle(radius),
            };
            shapes.Sort();
        }
    }
}
