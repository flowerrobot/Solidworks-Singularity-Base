using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for ISelectionMgr
    /// </summary>
    public interface ISingleSelectionManager
    {
        ISelectionMgr SelectionMgr { get; }

       ISelectData CreateSelectData { get; }
    }
}
