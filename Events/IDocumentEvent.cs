using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase.Events
{
    public interface IDocumentEvent
    {
        ISingleSldWorks Solidworks { get; }
        ISingleModelDoc Document { get; }
    }
}
