using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase
{
    [Obsolete("Information can be defined assembly of dll", true)]
    interface ISinglePlugIn
    {
        /// <summary>
        /// Description of the plugin 
        /// </summary>
        string Description { get;  }
        /// <summary>
        /// Title of the Plugin
        /// </summary>
        string Title { get;  }
        /// <summary>
        /// Version of the assembly
        /// </summary>
        string AssemblyVersion { get; }


    }
}
