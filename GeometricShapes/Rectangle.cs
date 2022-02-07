using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region CalculateRectanglePerimeterAndArea
namespace GeometricShapes {
    public class Rectangle {
        // Properties with Height & Width
        public int Height { get; set; }
        public int Width { get; set; }

        // Constructor
        public Rectangle(int height, int width) {
            Height = height;
            Width = width;
        }

        // Create a method to calculate the perimeter of
        // a virtual rectangle and printing
        public void PrintPerimeter() {
            // Equation to calculates the Perimeter value
            // given Height and Width
            int perimeter = (Height + Width) * 2;

            // A ConsoleWriteLine statement to print the height,
            // width and the perimeter of the virtual rectangule
            Console.WriteLine($"A rectangle with a height of {Height}, and a " +
                $"width of {Width} has a perimeter of {perimeter}.");
        }
        // Creating a Method called PrintArea to find Area of Rectangle
        public void PrintArea() {
            // Calculating the Area given the Height and Width
            int area = Height * Width;

            // Printing the Height, Width & Area in a
            // Console.WriteLine statement
            Console.WriteLine($"\nA rectangle with a height of {Height}, and " +
                $"a width of {Width} has a area of {area}.\n");
        }

    }

}
#endregion