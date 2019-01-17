using System;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for IAnnotation
    /// </summary>
    public interface ISingleAnnotation : ISingleObject, IDisposable
    {
        IAnnotation Annotation { get; }

        /// <summary>
        /// Annotation view for this annotation.  
        /// </summary>
        ISingleAnnotationView View { get; }
    }
}
