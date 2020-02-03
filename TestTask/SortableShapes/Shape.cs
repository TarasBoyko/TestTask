using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.SortableShapes
{
    // Implements rectangle abstraction.
    abstract class Shape : IComparable
    {
        // Calculates Area of Shape object.
        public abstract double CalculateArea();

        // Compares area of this object with area of @obj
        // @obj specifies object for comparing.
        public int CompareTo(object obj)
        {
            Shape rhs = (Shape)obj;
            double areaOfLhs = CalculateArea();
            double areaOfRhs = rhs.CalculateArea();
            if (areaOfLhs < areaOfRhs)
            {
                return -1;
            }

            if (areaOfLhs > areaOfRhs)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
