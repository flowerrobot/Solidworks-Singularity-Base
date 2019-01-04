using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase.UI
{
    /// <summary>
    /// A work around since constructors can't be enforced in an interface
    /// </summary>
    public interface ISwInit
    {
        /// <summary>
        /// A work around since constructors can't be enforced in an interface
        /// </summary>
        void Init(ISingleSldWorks solidworks);
    }
}
