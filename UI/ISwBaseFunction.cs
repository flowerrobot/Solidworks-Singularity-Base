using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SingularityBase.UI;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    public  interface ISwBaseFunction
    {
        /// <summary>
        /// This SW App
        /// </summary>
        ISingleSldWorks SolidWorks { get; set; }
       
      

        /// <summary>
        /// Name of the Command it should be called
        /// </summary>
        string CommandName { get; }

        /// <summary>
        /// This command information - this will be set by singularity
        /// </summary>
        ISingleCommandDef CommandData { get; set; }
    }
}
