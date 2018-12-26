using SingularityBase.Events;
using SingularityBase.Managers;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase
{
    public interface ISingleAssemblyDoc : ISingleModelDoc, IAssemblyEvents
    {
        new AssemblyDoc Document { get; }
        ISingleCustomPropertyManager CustomPropertyManager(string configName);

        IEnumerable< ISingleConfiguration> Configurations { get; }
        ISingleConfiguration Configuration(string name);

    }
}
