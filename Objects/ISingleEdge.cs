using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for IEdge & IEntity
    /// </summary>
    public interface ISingleEdge: ISingleBaseObject<IEdge>,  IEquatable<IEdge>
    {
        /// <summary>
        /// Add highlights or removes highlights from this edge.   
        /// </summary>
        bool Highlight {  set; }

        /// <summary>
        ///  Uses the X,Y,Z input point and returns the closest point on the edge. 
        /// </summary>
        ISinglePoint GetClosestPointOn(ISinglePoint point);

        /// <summary>
        /// Gets the underlying curve for this edge. 
        /// </summary>
         ICurve GetCurve {get;}

        /// <summary>
        /// Gets the ending vertex for this edge. 
        /// </summary>
        ISingleVertex GetEndVertex { get; }

        /// <summary>
        /// Gets the starting vertex for this edge.   
        /// </summary>
        ISingleVertex GetStartVertex { get; }
        /// <summary>
        /// Gets the body for this edge.  
        /// </summary>
        ISingleBody Body { get; }
        /// <summary>
        /// Length of the Edge
        /// </summary>
        double Length { get; }

        /// <summary>
        /// Gets the two faces adjacent to an edge.  
        /// </summary>
        ISingleFace[] GetTwoAdjacentFaces { get; }
    }
}
