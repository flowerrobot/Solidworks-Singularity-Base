using SingularityBase.Events;
using SingularityBase.Managers;
using SolidWorks.Interop.sldworks;
using System.Collections.Generic;

namespace SingularityBase
{
    public interface ISinglePartDoc : ISingleModelDoc, IPartEvents
    {
        PartDoc Document { get; }
        ISingleCustomPropertyManager CustomPropertyManager(string configName);

        IEnumerable<ISingleConfiguration> Configurations { get; }
        ISingleConfiguration Configuration(string name);
    }
}
