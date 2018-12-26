using SingularityBase.UI.Ribbon;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SingularityBase
{
    public interface ISingleSldWorks
    {
        
        ISldWorks Solidworks { get; }
        int AddinId { get; }
        int GetNextID { get; }


        ISingleModelDoc GetDocumentByName(string name);

        ReadOnlyCollection<IRibbonCollection> Ribbons { get; }
        /// <summary>
        /// Will retrieve or optionally create is not found a new Ribbon
        /// The name of the ribbon must be unique and can be shared across modules.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="createIfMissing"></param>
        /// <returns></returns>
        IRibbonCollection GetRibbonByName(string name = "", bool createIfMissing = true);

        CommandManager CommandManager { get; }
    }
}
