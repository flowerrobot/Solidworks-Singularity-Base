using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for IComponent2 
    /// </summary>
    public interface ISingleComponent : ISingleObject, ISelectable
    {
        ISingleConfiguration ReferencedConfiguration { get; }
        string ReferencedDisplayState { get; }
        IComponent2 Component { get; }

        IEnumerable<ISingleComponent> GetChildren { get; }
        int GetChildrenCount { get; }

        bool ExcludedFromBom { get; set; }

        bool IsRoot { get; }
        bool IsEnvelope { get; }


        /// <summary>
        /// Gets the body that belongs to this instance of this component. 
        /// </summary>
        ISingleBody GetBody { get; }
    }
}
