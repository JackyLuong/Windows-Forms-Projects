namespace ShapeConsoleApp
{
    /*
     * Main abstract class to ensure that all classes can calculate the area of its shape.
     * Each shape contains its own id.
     * Can contain other methods but it needs at least one abstract method
     */
    public abstract class Shape
    {
        private string shapeId = "";
        public abstract double CalculateArea(); // abstract has no code

        public string ShapeId 
        { get
            {
                return shapeId;
            }
          set
            {
                shapeId = value;
            }
        }
    }
}
