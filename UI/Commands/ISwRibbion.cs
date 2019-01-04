 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.swconst;

namespace SingularityBase.UI
{
    public interface ISwRibbon : ISwCommand
    {
        #region "Ribbion"      

        /// <summary>
        /// This is the name of the Ribbon Tab, this must not be a native Solidworks tab name.
        /// Leave blank for default
        /// </summary>
        string RibbonTabName { get;  }

        /// <summary>
        /// This name will categorize commands on a sub menu on the ribbon.
        /// Leave Blank for default
        /// </summary>
        string RibbonSubTabName { get;  }

        /// <summary>
        /// The order of which the command should be inserted on the ribbon
        /// </summary>
        
        int RibbonOrder { get; }

        /// <summary>
        /// The ribbon presentation
        /// </summary>
        swCommandTabButtonTextDisplay_e RibbonDisplayType { get;  }// = swCommandTabButtonTextDisplay_e.swCommandTabButton_TextBelow;

        /// <summary>
        /// The document types the ribbon is visible for
        /// </summary>
         DocumentTypes DocumentTypes { get; }
#endregion
    }
}
