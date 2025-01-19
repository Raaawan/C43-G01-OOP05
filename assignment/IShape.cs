using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal interface IShape
    {
        //Define an interface named IShape with a property Area and a method DisplayShapeInfo.
        #region properties
        public double Area { get; set; }
        #endregion

        #region methods
        public void DisplayShapeInfo();

        #endregion
    }
}
