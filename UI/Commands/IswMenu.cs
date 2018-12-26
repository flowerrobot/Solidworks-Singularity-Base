using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase.UI.Commands
{
    /// <summary>
    /// Defines the information to create a menu. If menu is not requires set MenuType to None.
    /// </summary>
    public interface ISwMenu 
    {
        #region "Menu Options"       
        
        /// <summary>
        /// The name of the Menu this command should be inserted onto. use \\ to indent menu.
        /// Leave Blank for default
        /// </summary>
        string MenuName { get; set; }

        /// <summary>
        /// The order of which the command should be inserted on the menu
        /// </summary>
        int MenuOrder { get; set; }

        /// <summary>
        /// This defines where the command should be seen, Ribbion, menu etc. 
        /// Leave Blank for default - All
        /// </summary>
        CommandLocation MenuType { get; set; } //= CommandLocation.All;

        
        #endregion
    }
}
