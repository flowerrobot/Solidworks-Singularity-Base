using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    public interface ISingleFeature :ISingleObject, ISelectable
    {
        int Id { get; }
        IFeature Feature { get; }

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
    }
}
