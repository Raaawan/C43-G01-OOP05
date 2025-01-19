using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Rectangle : IRectangle
    {
        #region properties
        public double Area { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        #endregion

        #region constructor
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        #endregion
        #region methods
        public double calculateArea()
        {
            return Width*Length;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This is a rectangle and its width is: {Width} Length is:{Length} and Area is: {calculateArea()}");
        }
        #endregion

    }
}
