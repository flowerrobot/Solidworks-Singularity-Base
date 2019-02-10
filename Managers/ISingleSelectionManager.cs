using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for ISelectionMgr
    /// </summary>
    public interface ISingleSelectionManager : ISingleBaseObject<ISelectionMgr>
    {

        ISingleBaseObject<ISelectData> CreateSelectData { get; }
    }
}
