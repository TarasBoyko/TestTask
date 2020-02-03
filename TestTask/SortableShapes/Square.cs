using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.SortableShapes
{
    // Implements square abstraction.
    class Square : Shape
    {
        // Initializes Square object.
        //@newSide specifies side of Square object.
        public Square(double newSide)
        {
            m_side = newSide;
        }

        // Implements Shape.CalculateArea().
        public override double CalculateArea()
        {
            return m_side * m_side;
        }

        protected double m_side;
    }
}
