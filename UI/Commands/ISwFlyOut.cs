using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using SolidWorks.Interop.swconst;

namespace SingularityBase.UI.Commands
{
    public interface ISwFlyOut : ISwCommand, ISwRibbion, ISwMenu
    {
        /// <summary>
        /// Determines the type of flyout button
        /// </summary>
        /// <value>
        /// The type of the flyout.
        /// </value>
          swCommandFlyoutStyle_e FlyoutType { get; }
        /// <summary>
        /// This defined the children that should be found within the flyout
        /// each item should be defined as  typeof(TesSubflyoutButton)  which are inherited from the swFlyOutButton class
        /// </summary>
        /// <value>
        /// The swFlyOutButton children.
        /// </value>
         ///Type[] SubButtons { get; }
        /// <summary>
        /// Lis of commands that are on the flyout
        /// </summary>
         ReadOnlyCollection<ISwFlyOutButton> Commands { get; }


        /// <summary>
        /// Will add a command to the list of commands
        /// </summary>
        /// <param name="commandName"></param>
        /// <returns></returns>
        ISwFlyOutButton AddCommand(string commandName);
      
    }
}
