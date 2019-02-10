
using System;

namespace SingularityBase
{
    public interface ISingleNamedObject<T> : ISingleBaseObject<T>
    {
        ISingleModelDoc Document { get; }
        string Name { get; }
    }
}
