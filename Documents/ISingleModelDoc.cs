using SingularityBase.Events;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Collections.Generic;

namespace SingularityBase
{
    public interface ISingleModelDoc : IDocumentEvents
    {

        ISingleSldWorks SldWorks { get; }
        swDocumentTypes_e Type { get; }

       
        ISingleCustomPropertyManager CustomPropertyManager();

        ISingleFeatureManagers FeatureManager { get; }
        ISingleSelectionManager SelectionManager { get; }

        ISingleModelView ActiveView { get; }

        void ClearSelection();

        bool EditUnsuppress(IEnumerable<IFeature> features);
        bool EditSuppress(IEnumerable<IFeature> features);
        bool EditUnsuppress(IEnumerable<ISingleFeature> features);
        bool EditSuppress(IEnumerable<ISingleFeature> features);
        bool EditUnsuppress();
        bool EditSuppress();

        bool ForceRebuild(bool TopOnly);

        /// <summary>
        /// Activates a loaded document and rebuilds it as specified. 
        /// </summary>
        /// <returns></returns>
        swActivateDocError_e ActivateDoc(bool useUserPreferences = true, swRebuildOnActivation_e option = swRebuildOnActivation_e.swDontRebuildActiveDoc);

        /// <summary>
        /// File name plus extension
        /// </summary>
        string FileName { get; }
        /// <summary>
        /// Full filename (Directory + File name + extension)
        /// </summary>
        string FullFileName { get; }
        /// <summary>
        /// The folder the file is found in.
        /// </summary>
        string FileDirectory { get; }


        /// <summary>
        /// Gets all tables \ BOMs \ revision tables in a file
        /// </summary>
        ITableManager Tables { get; }

        /// <summary>
        /// The generic Math Utility
        /// </summary>
        ISingleMathUtility MathUtility { get; }
    }
}
