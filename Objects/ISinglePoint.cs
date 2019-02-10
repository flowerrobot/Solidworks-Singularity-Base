using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    public interface ISinglePoint
    {
        /// <summary>
        /// The Math utility
        /// </summary>
        ISingleMathUtility MathUtility { get; }

        double X { get; set; }
        double Y { get; set; }
        double Z { get; set; }

        /// <summary>
        /// An array of 2 points (X,Y)
        /// </summary>
        double[] ToArray2 { get; set; }

        /// <summary>
        /// An array of the 3 points
        /// </summary>
        double[] ToArray3 { get; set; }

        /// <summary>
        /// One set, all fields are locked
        /// </summary>
        bool IsReadOnly { get; set; }

        ISinglePoint Clone { get; }

        /// <summary>
        /// This is the COM Object. Dealing with the raw object
        /// </summary>
        IMathPoint BaseObject { get; }

        /// <summary>
        /// Converts a math point to a math vector by using the three coordinates of the math point for the components of the math vector. 
        /// </summary>
        IMathVector ConvertToVector { get; }

        void Dispose();

        /// <summary>
        /// Translates a math point by a math vector to create a new math point.  
        /// </summary>
        void AddVector(IMathVector vec);

        /// <summary>
        /// Multiplies a math point with a math transform; the point is rotated, scaled, and then translated. 
        /// </summary>
        /// <param name=""></param>
        void MultiplyTransform(IMathTransform transform);

        /// <summary>
        /// Scales a math point's magnitude.  
        /// </summary>
        /// <param name="scale"></param>
        void Scale(double scale);

        /// <summary>
        /// Gets a math vector that describes the difference between the math point magnitude from the calling math point.  
        /// </summary>
        /// <param name="point"></param>
        void Subtract(ISinglePoint point);

        /// <summary>
        /// Gets a math point that describes the difference between a math vector's magnitude from the calling math point  
        /// </summary>
        /// <param name="vector"></param>
        void SubtractVector(IMathVector vector);
    }

}
