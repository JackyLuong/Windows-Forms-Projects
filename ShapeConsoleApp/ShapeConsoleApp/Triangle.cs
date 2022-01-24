using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeConsoleApp
{
    /*
     *   Calculates the area of a triangle
     */
    public class Triangle : Shape
    {
        private double triBase;
        private double triHeight;
        public Triangle(double _triBase, double _triHeight)
        {
            ShapeId = "triangle "; // Shape.shapeId
            this.triBase = _triBase;
            this.triHeight = _triHeight;
        }
        public override double CalculateArea()
        {
            double triArea = 0.5 * triBase * triHeight ;
            return triArea;
        }
    }
}
