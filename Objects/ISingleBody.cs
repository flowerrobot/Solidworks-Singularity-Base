using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    /// <summary>
    /// A wrapper for IBody2
    /// </summary>
    public interface ISingleBody : ISingleObject
    {
        IBody2 Body { get; }
    }
}
