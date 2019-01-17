using System.Collections.Generic;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for  IDrawingComponent
    /// </summary>
    public interface ISingleDrawingComponent : ISelectable
    {
        ISingleComponent Component { get; } //should it just inherit this?
    }
}
