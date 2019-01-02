using SingularityBase.Events;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase
{
    public interface ISingleDrawingDoc : ISingleModelDoc, IDrawingEvents
    {
        DrawingDoc Document { get; }
    }
}
