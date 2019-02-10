using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SingularityBase
{
    public interface ISingleFeature :ISingleNamedObject<IFeature>, ISelectable
    {
        int Id { get;  }
        new string Name { get; set; }
        FeatureName GetTypeName { get; }

        ISingleFeature GetNextFeature { get; }

        /// <summary>
        /// Feature is a wrapper for a more specific type
        /// This will convert feature into specific feature type.
        /// </summary>
        object GetSpecificFeature { get; }



        ISingleFeature GetFirstSubFeature { get; }
        ISingleFeature GetNextSubFeature(ISingleFeature next);
        IEnumerable<ISingleFeature> GetSubFeatures { get; }
        int GetSubFeaturesCount { get; }
        /// <summary>
        /// Gets the visibility state of this feature. 
        /// </summary>
        swVisibilityState_e Visible { get;  }

        /// <summary>
        /// Gets the bodies created by this feature.
        /// </summary>
       IList< ISingleBody> GetBodies { get; }
        /// <summary>
        /// Gets the faces in this feature. 
        /// </summary>
        IList<ISingleFace> GetFaces { get; }
    }
}
