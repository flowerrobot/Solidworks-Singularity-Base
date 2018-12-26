using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Collections.Generic;

namespace SingularityBase.Managers
{
    public interface ISingleCustomPropertyManager
    {
        ISingleModelDoc Document { get; }
        ISingleConfiguration Configuration { get; }
        ICustomPropertyManager CustomPropertyManager { get; }

        swCustomInfoAddResult_e Add(string Name, swCustomInfoType_e Type, string Value, int OverwriteExisting);

        IEnumerable<ISingleCustomProperty> GetAll();
        ISingleCustomProperty GetProperty(string Name);
        swCustomInfoDeleteResult_e Delete(string Name);
        swCustomInfoDeleteResult_e DeleteAll();
        swCustomInfoSetResult_e Set(string Name, string Value);
    }
}
