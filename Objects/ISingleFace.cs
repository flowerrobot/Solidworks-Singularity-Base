using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for IFace2
    /// </summary>
    public interface ISingleFace : ISingleBaseObject<IFace2>, ISingleEntity
    {
        ISingleFeature Feature { get; }
        int Id { get; set; }
        ISingleBody Body { get; }

        double GetArea { get; }
        int GetEdgeCount { get; }

        IMathVector Normal { get; }

        IList<ISingleEdge> GetEdges { get; }

        /// <summary>
        /// Gets the largest face adjacent to this;
        /// </summary>
        /// <param name="originFace"></param>
        /// <returns></returns>
        ISingleFace GetFaceAdjacentToLongestEdge { get; }
    }

}
