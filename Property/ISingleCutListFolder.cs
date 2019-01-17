using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Collections.Generic;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for the IBodyFolder
    /// </summary>
    public interface ISingleCutListFolder : ISingleCustomPropertyManager
    {
        string Name { get; }
        ISingleFeature Feature { get; }
        IBodyFolder CutFolder { get; }

        new ISingleModelDoc Document { get; }

        int GetBodyCount { get; }
        IEnumerable<ISingleBody> GetBodies { get; }

        swBodyFolderFeatureType_e Type { get; }
        swCutListType_e CutListType { get; }

        /// <summary>
        /// Gets whether to automatically generate a cut list when the first weldment feature is inserted in a part.  
        /// </summary>
        bool AutomaticCutList { get; set; }

        /// <summary>
        /// whether to automatically update cut lists.  
        /// </summary>
        bool AutomaticUpdate { get; set; }

        /// <summary>
        /// Updates an automatically generated cut list. 
        /// </summary>
        /// <returns></returns>
        bool UpdateCutList();

    }
}
