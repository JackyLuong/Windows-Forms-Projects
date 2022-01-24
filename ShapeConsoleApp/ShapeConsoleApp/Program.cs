using System;
using System.Collections.Generic;

namespace ShapeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle itmRect = new Rectangle(2, 2);
            Triangle itmTri = new Triangle(2, 2);
            Circle itmCrcl = new Circle(2);

            List<Shape> shapeLists = new List<Shape>();
            shapeLists.Add(itmRect);
            shapeLists.Add(itmTri);
            shapeLists.Add(itmCrcl);

            foreach(Shape shp in shapeLists)
            {
                Console.WriteLine($"ShapeID: {shp.ShapeId } ShapeArea: {shp.CalculateArea()}");
            }
        }
    }
}
