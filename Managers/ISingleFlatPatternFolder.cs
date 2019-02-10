using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for IFlatPatternFolder
    /// </summary>
    public interface ISingleFlatPatternFolder : ISingleBaseObject<IFlatPatternFolder>
    {
        /// <summary>
        /// Gets the feature for this flat-pattern folder
        /// </summary>
        ISingleFeature GetFeature { get; }

        /// <summary>
        /// Gets the number of flat patterns in this folder.  
        /// </summary>
        int GetFlatPatternCount { get; }

        //Gets the flat-pattern features in this folder.  
        IList<ISingleFeature> GetFlatPatterns { get; }

        /// <summary>
        /// Part Document
        /// </summary>
        ISinglePartDoc Document { get; }
    }
}
