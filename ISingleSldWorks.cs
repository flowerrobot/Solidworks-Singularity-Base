using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SingularityBase
{
    public interface ISingleSldWorks : IDisposable
    {
        
        ISldWorks Solidworks { get; }
        int AddinId { get; }
        int GetNextID { get; }


        ISingleModelDoc GetDocumentByName(string name);

        CommandManager CommandManager { get; }
    }
}
