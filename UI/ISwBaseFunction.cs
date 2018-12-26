using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{
    public  interface ISwBaseFunction
    {
        //This SW App
        ISingleSldWorks SwApp { get; }
        /// <summary>
        /// The fuctions unquie ID
        /// </summary>
        int Id { get; }
        /// <summary>
        /// This SW Addin ID
        /// </summary>
        int AddinId { get; }
        /// <summary>
        /// Defines the type of command
        /// </summary>
        CommandType CmdType { get; }

        /// <summary>
        /// Name of the Command it should be called
        /// </summary>
        string CommandName { get; }

      
    }
}
