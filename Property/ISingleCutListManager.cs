using SolidWorks.Interop.sldworks;
using System.Collections.Generic;

namespace SingularityBase
{

    /// <summary>
    /// Is a collect of cutlist items.
    /// </summary>
    public interface ISingleCutListManager
    {
        ISinglePartDoc Document { get; }
      //  ICustomPropertyManager CustomPropertyManager { get; }

       // IFeature CutFeature { get; }
        //IBodyFolder CutFolder { get; }

        IEnumerable<ISingleCutListFolder> CutListFolders { get; }
        int CutListCount { get; }

        bool UpdateCutList();
        bool UpdateCutList(bool RebuildFlatPattern);
       // bool AutomaticUpdate { get; set; }
       // bool AutomaticCutList { get; }
    }
}
