using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SingularityBase.UI.Icons;
using SolidWorks.Interop.sldworks;

namespace SingularityBase.UI.Commands
{
    public delegate void CommandExecutedEventHandler(ISwCommand command);
    public delegate IconEnabled IconStateQueryEventHandler(ISwCommand command);
    public interface ISwCommand : ISwBaseFunction
    {
        /// <summary>
        /// ID of the button given by solidworks
        /// </summary>
        int ButtonId { get; }

        /// <summary>
        /// The tool tip discription shown when you mouse over the button on the ribbion
        /// </summary>
        string CommandToolTop { get; } //= "This is the HintTip";

        /// <summary>
        /// When the button is pushed, this event is fired
        /// </summary>
        event CommandExecutedEventHandler CommandExecuted;

        /// <summary>
        /// Triggered when the UI requests update on the Icon State.
        /// </summary>
        event IconStateQueryEventHandler IconStateQuery;

        /// <summary>
        /// Command manager reference
        /// </summary>
        ICommandManager CmdMgr { get; }

        /// <summary>
        /// Icons to be used
        /// </summary>
        IIconDef Icons { get; }

        /// <summary>
        /// Indicates the Icon state
        /// </summary>
        /// <returns></returns>
        IconEnabled IconState { get; }

        /// <summary>
        /// Allows you to had a seperator on Menu &\or Ribbion before or after the command.
        /// </summary>
        SeperatorLocation Seperator { get; }
    }
}
