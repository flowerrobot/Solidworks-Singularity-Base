using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;

namespace SingularityBase.UI
{
    //public delegate void CommandExecutedEventHandler(ISwCommand command);
    //public delegate IconEnabled IconStateQueryEventHandler(ISwCommand command);
    public interface ISwCommand : ISwBaseFunction
    {
        /// <summary>
        /// This command information
        /// </summary>
        new ISingleCommandDef CommandData { get; set; }

        /// <summary>
        /// The tool tip description shown when you mouse over the button on the ribbion
        /// </summary>
        string CommandToolTop { get; } //= "This is the HintTip";

        ///// <summary>
        ///// When the button is pushed, this event is fired
        ///// </summary>
        //event CommandExecutedEventHandler CommandExecuted;

        ///// <summary>
        ///// Triggered when the UI requests update on the Icon State.
        ///// </summary>
        //event IconStateQueryEventHandler IconStateQuery;

       /// <summary>
        /// Icons to be used
        /// </summary>
        IIconDef Icons { get; }

        /// <summary>
        /// Indicates the Icon state
        /// </summary>
        /// <returns></returns>
        ///IconEnabled IconState { get; }

        /// <summary>
        /// Allows you to had a separator on Menu &\or Ribbon before or after the command.
        /// </summary>
        SeperatorLocation Separator { get; }


        /// <summary>
        /// The function called when the button is pushed by the user
        /// </summary>
        void ActionCallback();

        /// <summary>
        /// Indicates the Icon state
        /// </summary>
        /// <returns></returns>
        IconEnabled IconState { get; }
    }
}
