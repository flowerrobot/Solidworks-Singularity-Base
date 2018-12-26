using SolidWorks.Interop.sldworks;
using System.Collections.Generic;

namespace SingularityBase.Managers
{
    public interface ISingleCutListManager
    {
        ISinglePartDoc Document { get; }
        ICustomPropertyManager CustomPropertyManager { get; }

        IFeature CutFeature { get; }
        IBodyFolder CutFolder { get; }

        IEnumerable<ISingleCutListFolder> CutListFolders { get; }

        bool UpdateCutList();
        bool UpdateCutList(bool RebuildFlatPattern);
        bool AutomaticUpdate { get; set; }
        bool AutomaticCutList { get; }
    }
}
