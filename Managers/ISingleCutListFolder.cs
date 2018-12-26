using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SingularityBase.Managers
{
    public interface ISingleCutListFolder : ISingleCustomPropertyManager
    {
        string Name { get; }
        IFeature Feature { get; }
        BodyFolder CutFolder { get; }

        new ISinglePartDoc Document { get; }

        IBodyFolder[] GetBodies { get; }


        swCutListType_e Type { get; }
    }
}
