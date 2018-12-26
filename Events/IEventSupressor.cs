using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase.Events
{
    public interface IEventSupressor : IDisposable
    {
        IDocumentEvents Owner { get; }
        int Id { get; }
        bool IsDisposed { get; }


    }
}
