using System;

#region CalculatingTheRectanglePerimeterAndArea
namespace GeometricShapes {
    class Program {
        static void Main(string[] args) {

            // A rectangle with setting the Height and Width
            Rectangle rect = new Rectangle(2, 5);

            // Calling the PrintPerimeter method
            rect.PrintPerimeter();

            // Calling the PrintArea method
            rect.PrintArea();
            /////////////////////////////////////////////////////////////////
            // Modified Calculating the Perimeter & Area of a Rectangle
            AnotherMethodRectangle rect2 = new AnotherMethodRectangle(3, 5);
            rect2.PrintPerimeter2();
            rect2.PrintArea2();

        }
    }
}
#endregion
