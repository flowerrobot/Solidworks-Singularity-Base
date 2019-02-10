using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SingularityBase
{
    /// <summary>
    /// A wrapper for IBody2
    /// </summary>
    public interface ISingleBody : ISingleNamedObject<IBody2>, ISelectable, IEquatable<ISingleBody>
    {
        /// <summary>
        /// Hide or show the body
        /// </summary>
        bool Visible { get; set; }
        /// <summary>
        /// Gets the type of the body
        /// </summary>
        swBodyType_e Type { get; }

        IList<ISingleFeature> Features { get; }

        IList<ISingleFace> Faces { get; }


        ISingleFace GetLargestFace { get; }
        /// <summary>
        /// Find the perpendicular face with the largest area
        /// </summary>
        /// <param name="originFace"></param>
        /// <param name="faces"></param>
        /// <returns></returns>
        ISingleFace GetLargestOrthogonalFace(ISingleFace originFace);

        /// <summary>
        /// Gets the largest face adjacent to this;
        /// </summary>
        /// <param name="originFace"></param>
        /// <returns></returns>
        ISingleFace GetFaceAdjacentToLongestEdge(ISingleFace originFace);
    }
   

}
