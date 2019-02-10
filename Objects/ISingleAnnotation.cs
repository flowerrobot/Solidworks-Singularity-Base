using System;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for IAnnotation
    /// </summary>
    public interface ISingleAnnotation : ISingleNamedObject<IAnnotation>
    {

        /// <summary>
        /// Annotation view for this annotation.  
        /// </summary>
        ISingleAnnotationView View { get; }
    }
}
