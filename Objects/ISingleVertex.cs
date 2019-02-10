using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for IVertex & IEntity
    /// </summary>
    public interface ISingleVertex: ISingleBaseObject<IVertex>,  IEquatable<IVertex>
    {
        /// <summary>
        /// Gets a list of enumerated edges corresponding to this vertex.  
        /// </summary>
        IList<ISingleEdge> Edges { get; }
        /// <summary>
        /// Gets the faces adjacent to this vertex.  
        /// </summary>
        IList<ISingleFace> AdjacentFaces { get; }
        /// <summary>
        /// Gets the closest point on the vertex using the X, Y, Z input point.  
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        ISinglePoint GetClosestPointOn(ISinglePoint point);
        /// <summary>
        /// Gets the point corresponding to this vertex.  
        /// </summary>
        ISinglePoint Point { get; }
    }
}
