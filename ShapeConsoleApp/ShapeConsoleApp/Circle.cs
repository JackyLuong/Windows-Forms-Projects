using System;

namespace ShapeConsoleApp
{
    /*
     * Calculate the area of a circle
     */
    public class Circle : Shape // extends the shape class
    {
        private double radius;
        public Circle(double _radius) // requires a value of the radius of the circle
        {
            this.radius = _radius;
            ShapeId = "cirlce "; // Shape.shapeId
        }
        //Calcuates the area of the circle given the radius
        public override double CalculateArea()
        {
            double circleArea;
            double PI = Math.PI;

            circleArea = PI * (radius * radius);
            return circleArea;
        }
    }
}
