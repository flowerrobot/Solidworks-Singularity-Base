using SingularityBase.Events;
using SolidWorks.Interop.sldworks;
using System.Collections.Generic;
using SolidWorks.Interop.swconst;

namespace SingularityBase
{
    public interface ISinglePartDoc : ISingleModelDoc, IPartEvents
    {
        PartDoc Document { get; }
        ISingleCustomPropertyManager CustomPropertyManager(string configName);

        /// <summary>
        /// If component has sheetmetal or cutlist components
        /// </summary>
        bool HasCutList { get; }
        ISingleCutListManager CutList { get; }

        IEnumerable<ISingleConfiguration> Configurations { get; }
        ISingleConfiguration Configuration(string name);
        ISingleConfiguration ActiveConfiguration { get; }

        
    }
}
