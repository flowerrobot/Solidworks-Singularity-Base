using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Collections.Generic;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for IView 
    /// </summary>
    public interface ISingleView : ISingleObject
    {
        IView View { get; }
        ISingleView GetNextView { get; }

        int GetTableAnnotationCount { get; }

        /// <summary>
        /// returns a BOM table if there is a Microsoft Excel-based BOM for the drawing view
        /// </summary>
        IBomTable GetBomTable { get; }

        /// <summary>
        /// access to table annotations. 
        /// </summary>
        IEnumerable<ISingleTableAnnotation> GetTableAnnotations { get; }

        string ReferencedConfiguration { get; set; }

        swDrawingViewTypes_e Type { get; }


        ISingleDrawingComponent RootDrawingComponent { get; }

    }
}
