using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes {
    public class AnotherMethodRectangle {
        public int Height { get; set; }
        public int Width { get; set; }

        public AnotherMethodRectangle(int height, int width) {
            Height = height;
            Width = width;
        }

        public void PrintPerimeter2() {
            int perimeter = AnotherMethodRectangle.CalculatePerimeter2(Height, Width);
            Console.WriteLine($"Another rectangle with a height of {Height}, and a " +
                $"width of {Width} has a perimeter of {perimeter}.");
        }
        // Method called PrintArea2
        public void PrintArea2() {
            int area = CalculateArea2(Height, Width);
            Console.WriteLine($"\nAnother rectangle with a height of {Height}, and " +
                $"a width of {Width} has a area of {area}.");
        }
        /////////////////////////////////////////////////////////////////////////////
        public static int CalculatePerimeter2(int height, int width) {
            return (height + width) * 2;
        }

        public static int CalculateArea2(int height, int width) {
            return height * width;
        }
    }
}
