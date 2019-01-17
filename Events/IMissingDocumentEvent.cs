using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase.Events
{
    public interface IMissingDocumentEvent
    {
        string MissingFileName { get; }
        string NewFileName { get; set; }
        bool UseNewPath { get; set; }
    }
}
