using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase.UI
{
    public interface ISwCustomFunction : ISwBaseFunction
    {
        /// <summary>
        /// A work around since constructors can't be enforced in an interface
        /// </summary>
        void Init(ISldWorks solidworks );
    }
}
