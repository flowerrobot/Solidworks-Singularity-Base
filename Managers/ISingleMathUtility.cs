using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for IMath Utitlity
    /// </summary>
    public interface ISingleMathUtility : ISingleBaseObject<IMathUtility>
    {
        /// <summary>
        /// Creates a new math point.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        ISinglePoint CreatePoint(double x, double y, double z);
        /// <summary>
        /// Creates a new math point.
        /// </summary>
        /// <param name="vals"></param>
        /// <returns></returns>
        ISinglePoint CreatePoint(double[] vals);

        /// <summary>
        /// Creates a new math transform.  
        /// </summary>
        IMathTransform CreateTransform(double[] array);
        /// <summary>
        /// Creates a new math transform matrix that represents the rotation by an angle about a vector positioned at a point
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        IMathTransform CreateTransformRotateAxis(ISinglePoint point,IMathVector  vector, double angle);

        /// <summary>
        /// Creates a math vector
        /// </summary>
        /// <param name="array">3 values</param>
        /// <returns></returns>
        IMathVector CreateVector(double[] array);
        /// <summary>
        /// Create a math vector
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        IMathVector CreateVector(ISinglePoint point);
    }
}
