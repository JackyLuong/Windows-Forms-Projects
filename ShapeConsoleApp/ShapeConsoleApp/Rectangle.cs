namespace ShapeConsoleApp
{
    /*
     *   Calculates the area of a rectangle
     */
    public class Rectangle : Shape
    {
        private double recBase;
        private double recHeight;
        public Rectangle(double _recBase, double _recHeight)
        {
            this.recBase = _recBase;
            this.recHeight = _recHeight;
            ShapeId = "rectangle "; // Shape.shapeId
        }
        public override double CalculateArea()
        {
            double recArea = recBase * recHeight;
            return recArea;
        }
    }
}
