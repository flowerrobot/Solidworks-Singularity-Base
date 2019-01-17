using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.swconst;

namespace SingularityBase
{
    public interface ISingleConfiguration : ISingleObject
    {
        new string Name { get; set; }
        string ConfigName { get; set; }
        IConfiguration Configuration { get; }
        ISingleCustomPropertyManager CustomPropertyManager { get; }

        swConfigurationType_e Type { get; }

        IEnumerable<ISingleConfiguration> ChildConfigurations { get; }
    }
}
