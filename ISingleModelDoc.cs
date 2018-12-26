using SingularityBase.Events;
using SingularityBase.Managers;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase
{
    public interface ISingleModelDoc : IDocumentEvents
    {

        ISingleSldWorks SldWorks { get; }
        swDocumentTypes_e Type { get; }

        ISingleCustomPropertyManager CustomPropertyManager();

        IFeature GetFirstFeature { get; }
        IFeature GetNextFeature(IFeature next);
        IEnumerable<IFeature> GetFeatures { get; }

        ISingleModelView ActiveView { get; }

        void ClearSelection();

        bool EditUnsuppress(IEnumerable<IFeature> features);
        bool EditSuppress(IEnumerable<IFeature> features);

        bool ForceRebuild(bool TopOnly);
    }
}
