using SolidWorks.Interop.sldworks;
using System;

namespace SingularityBase
{
    public interface ISingleModelView :IDisposable
    {
        ISingleModelDoc Document { get; }
        IModelView ModelView { get; }
        bool EnableGraphicsUpdate { get; set; }
        /// <summary>
        /// Will set Graphics update to false  with a dispoble which will set it back
        /// </summary>
        IDisposable DisableGraphicsUpdate { get; }
    }
}
