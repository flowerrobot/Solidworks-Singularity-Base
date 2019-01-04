using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase.UI
{
    /// <summary>
    /// This is the wrapper for the commands where Singularity takes control
    /// </summary>
    public interface ISingleCommandDef
    {
        /// <summary>
        /// ID of the button given by solidworks
        /// </summary>
        int ButtonId { get; }

        /// <summary>
        /// This SW App
        /// </summary>
        ISingleSldWorks Solidworks { get; }
        
     
        /// <summary>
        /// ID given by the Singularity
        /// </summary>
        int Id { get; }

        /// <summary>
        /// The command of which the user has defined
        /// </summary>
        ISwBaseFunction Command { get; }

        /// <summary>
        /// Defines the type of command
        /// </summary>
        CommandType CmdType { get; }

        /// <summary>
        /// Indicates of the Menu was implemented. This will always be false for Flyout Groups.
        /// </summary>
        bool MenuImplemented { get; }
    }
}
