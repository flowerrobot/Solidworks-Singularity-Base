using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for IAnnotationView
    /// </summary>
    public interface ISingleAnnotationView : ISingleBaseObject<IAnnotationView>
    {
        
        /// <summary>
        /// Gets whether this annotation view is a flat-pattern view. 
        /// </summary>
        bool FlatPatternView { get; }

        /// <summary>
        /// Shows the annotations in an annotation view that is not activated.  
        /// </summary>
        bool Show { get; set; }
    }
}
