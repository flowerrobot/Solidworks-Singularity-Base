 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.swconst;

namespace SingularityBase.UI.Commands
{
    public interface ISwRibbion : ISwCommand
    {
        #region "Ribbion"      

#if ModuleNotUsed
        /// <summary>
        /// This is the name of the Ribbion Tab, this must not be a native Solidworks tab name.
        /// Leave blank for default
        /// </summary>
        string RibbionTabName { get; set; }
        /// <summary>
        /// This name will catagorise commands on a sub menu on the ribbon.
        /// Leave Blank for default
        /// </summary>
        string RibbionSubTabName { get; set; }
#endif 
        /// <summary>
        /// The order of which the command should be inserted on the ribbion
        /// </summary>
        
        int RibbonOrder { get; }
        /// <summary>
        /// The ribbion presentation
        /// </summary>
        swCommandTabButtonTextDisplay_e RibbionDisplayType { get;  }// = swCommandTabButtonTextDisplay_e.swCommandTabButton_TextBelow;
        /// <summary>
        /// The document types the ribbion is visible for
        /// </summary>
         DocumentTypes DocumentTypes { get; }
#endregion
    }
}
