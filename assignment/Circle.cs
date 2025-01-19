using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Circle : ICircle
    {
        #region properties
        public double Radius { get; set; }
        public double Area { get; set; }
        #endregion

        #region constructor
        public Circle(double radius)
        {
            Radius = radius;
        }
        #endregion

        #region method
        
        public double calculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This is a circle and its raduis is: {Radius} and Area is: {calculateArea()}");
        }
        #endregion

    }
}
