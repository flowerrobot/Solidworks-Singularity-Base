using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase.Managers
{
    public interface ISingleCustomProperty
    {
        string Name { get; set; }
        string RawValue { get; set; }
        string ResolvedValue { get; }
        swCustomInfoType_e Type { get; set; }

        string Configuration { get; }

        ISingleModelDoc Document { get; }

        ISingleCustomPropertyManager CustPropMgr { get;  }
        CustomPropertyType CustomPropertyType { get;  }
    }
}
