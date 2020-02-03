using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.SortableShapes
{
    // Implements triangle abstraction.
    class Triangle : Shape
    {
        // Initializes Triangle object.
        //@newWidth specifies width of Triangle object.
        //@newHeight specifies height of Triangle object.
        public Triangle(double newWidth, double newHeight)
        {
            m_width = newWidth;
            m_height = newHeight;
        }

        // Implements Shape.CalculateArea().
        public override double CalculateArea()
        {
            return m_width * m_height / 2.0;
        }

        protected double m_width;
        protected double m_height;
    }
}
