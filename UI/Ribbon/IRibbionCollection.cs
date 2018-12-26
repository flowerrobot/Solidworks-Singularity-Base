using System.Collections.ObjectModel;

namespace SingularityBase.UI.Ribbon
{
    public interface IRibbonCollection
    {
        ReadOnlyCollection<IRibbonGroupCollection> SubRibbons { get; }

        string RibbonName { get; set; }
         ISingleSldWorks SwApp { get; }
        int Id { get; }
        /// <summary>
        /// Gets Ribbon sub Group, or creates is if nessary
        /// </summary>
        /// <param name="name"></param>
        /// <param name="createIfMissing"></param>
        /// <returns></returns>
        IRibbonGroupCollection GetTabByName(string name, bool createIfMissing);
        /// <summary>
        /// Gets Ribbon sub Group or default group
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IRibbonGroupCollection GetTabByName(string name = "");
    }
}
