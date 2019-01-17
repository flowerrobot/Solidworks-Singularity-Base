using SingularityBase.Events;
using SolidWorks.Interop.sldworks;
using System.Collections.Generic;

namespace SingularityBase
{
    public interface ISinglePartDoc : ISingleModelDoc, IPartEvents
    {
        PartDoc Document { get; }
        ISingleCustomPropertyManager CustomPropertyManager(string configName);

        ISingleCutListManager CutList { get; }

        IEnumerable<ISingleConfiguration> Configurations { get; }
        ISingleConfiguration Configuration(string name);
        ISingleConfiguration ActiveConfiguration { get; }
    }
}
