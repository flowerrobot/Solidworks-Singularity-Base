
using System;

namespace SingularityBase
{
    public interface ISingleObject
    {
        ISingleModelDoc Document { get; }
        string Name { get; }
    }
}
