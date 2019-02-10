using SolidWorks.Interop.sldworks;
using System.Collections.Generic;
using SolidWorks.Interop.swconst;

namespace SingularityBase
{

    /// <summary>
    /// Is a collect of cutlist items.
    /// </summary>
    public interface ISingleCutListManager
    {
        ISinglePartDoc Document { get; }
        //  ICustomPropertyManager CustomPropertyManager { get; }

        // IFeature CutFeature { get; }
        //IBodyFolder CutFolder { get; }
        IList<ISingleCutListFolder> CutListFolders { get; }
        int CutListCount { get; }

        bool UpdateCutList();
        bool UpdateCutList(bool RebuildFlatPattern);
        // bool AutomaticUpdate { get; set; }
        // bool AutomaticCutList { get; }

        /// <summary>
        /// Adds a custom property for each cut list item
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <param name="overrideIfExisting"></param>
        void AddCustomProperty(string name, swCustomInfoType_e type, string value, swCustomPropertyAddOption_e overrideIfExisting);
        /// <summary>
        /// Will delete the custom property if found on each cut list
        /// </summary>
        /// <param name="name"></param>
        void DeleteCustomProperty(string name);
        /// <summary>
        /// Will delete all custom properties for each cut list item
        /// </summary>
        void DeleteAllCustomProperties();

        /// <summary>
        /// Will find the cut list folder for each body
        /// </summary>
        /// <param name="bodies"></param>
        /// <returns></returns>
        IDictionary<ISingleBody, ISingleCutListFolder> GetCutListFolders(IList<ISingleBody> bodies);

    }
}
