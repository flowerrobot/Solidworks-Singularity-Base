using System;
using System.Collections.ObjectModel;

namespace SingularityBase.UI
{
    public interface IRibbonCollection :IDisposable
    {
        ReadOnlyCollection<IRibbonGroupCollection> SubRibbons { get; }

        string RibbonName { get;  }
         ISingleSldWorks Solidworks { get; }
        int Id { get; }
        /// <summary>
        /// Gets Ribbon sub Group, or creates is if nessary. 
        /// </summary>
        /// <param name="name">Can be blank for default</param>
        /// <param name="createIfMissing"></param>
        /// <returns></returns>
        IRibbonGroupCollection GetTabByName(string name, bool createIfMissing);
        /// <summary>
        /// Gets Ribbon sub Group or default group
        /// </summary>
        /// <param name="name">Can be blank for default</param>
        /// <returns></returns>
        IRibbonGroupCollection GetTabByName(string name);
    }
}
