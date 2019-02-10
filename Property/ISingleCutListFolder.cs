using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Collections.Generic;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for the IBodyFolder
    /// </summary>
    public interface ISingleCutListFolder : ISingleBaseObject<IBodyFolder>, ISingleCustomPropertyManager
    {
        string Name { get; set; }
        int Id { get; }
        ISingleFeature Feature { get; }

        new ISingleModelDoc Document { get; }

        int GetBodyCount { get; }
        IList<ISingleBody> GetBodies { get; }

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
