using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.swconst;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for IConfiguration
    /// </summary>
    public interface ISingleConfiguration : ISingleNamedObject<IConfiguration>
    {
        int id { get; }
        new string Name { get; set; }
        string ConfigName { get; set; }
        ISingleCustomPropertyManager CustomPropertyManager { get; }

        swConfigurationType_e Type { get; }

        IList<ISingleConfiguration> ChildConfigurations { get; }
        ISingleConfiguration Parent { get; }

        bool IsDerived { get; }


        Dictionary<string, string> Parameters { get; set; }
       
    }
}
