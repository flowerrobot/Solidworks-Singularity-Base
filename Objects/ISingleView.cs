using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Collections.Generic;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for IView 
    /// </summary>
    public interface ISingleView :  ISingleNamedObject<IView>
    {
        ISingleView GetNextView { get; }

        int GetTableAnnotationCount { get; }

        /// <summary>
        /// returns a BOM table if there is a Microsoft Excel-based BOM for the drawing view
        /// </summary>
        ISingleBaseObject<IBomTable> GetBomTable { get; }

        /// <summary>
        /// access to table annotations. 
        /// </summary>
        IEnumerable<ISingleTableAnnotation> GetTableAnnotations { get; }

        string ReferencedConfiguration { get; set; }

        swDrawingViewTypes_e Type { get; }


        ISingleDrawingComponent RootDrawingComponent { get; }

        ISingleModelDoc ReferencedDocument { get; }

        /// <summary>
        /// Gets whether a drawing view is a flat-pattern drawing view. 
        /// </summary>
        bool IsFlatPatternView { get; }

        /// <summary>
        /// Gets the bodies of a multibody part in the drawing view. 
        /// </summary>
       IList<ISingleBody> GetBodies { get; }


    }
}
