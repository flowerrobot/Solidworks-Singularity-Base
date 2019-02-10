using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Collections.Generic;

namespace SingularityBase
{
    public interface ISingleCustomPropertyManager : ISingleBaseObject<ICustomPropertyManager>
    {
        ISingleModelDoc Document { get; }
        ISingleConfiguration Configuration { get; }

        swCustomInfoAddResult_e Add(string Name, swCustomInfoType_e Type, string Value, swCustomPropertyAddOption_e OverwriteExisting);

        IEnumerable<ISingleCustomProperty> GetAll();
        ISingleCustomProperty GetProperty(string Name);
        swCustomInfoDeleteResult_e Delete(string Name);
        swCustomInfoDeleteResult_e DeleteAll();
        swCustomInfoSetResult_e Set(string Name, string Value);
    }
}
