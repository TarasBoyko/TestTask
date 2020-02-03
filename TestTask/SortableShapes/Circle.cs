using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.SortableShapes
{
    // Implements сircle abstraction.
    class Circle : Shape
    {
        // Initializes Circle object.
        //@newRadius specifies radius of Circle object
        public Circle(double newRadius)
        {
            m_radius = newRadius;
        }

        // Implements Shape.CalculateArea().
        public override double CalculateArea()
        {
            return Math.PI * m_radius * m_radius;
        }

        protected double m_radius;
    }
}
