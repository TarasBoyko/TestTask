using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.SortableShapes
{
    // Implements rectangle abstraction.
    class Rectangle : Shape
    {
        // Initializes Rectangle object.
        //@newWidth specifies width of Rectangle object.
        //@newHeight specifies height of Rectangle object.
        public Rectangle(double newWidth, double newHeight)
        {
            m_width = newWidth;
            m_height = newHeight;
        }

        // Implements Shape.CalculateArea().
        public override double CalculateArea()
        {
            return m_width * m_height;
        }

        protected double m_width;
        protected double m_height;
    }
}
