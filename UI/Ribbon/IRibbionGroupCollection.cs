using SingularityBase.UI.Commands;
using SingularityBase.UI.Icons;
using SolidWorks.Interop.swconst;
using System.Collections.ObjectModel;

namespace SingularityBase.UI.Ribbon
{
    public interface IRibbonGroupCollection
    {
        string TabName { get; }

        ReadOnlyCollection<ISwCommand> Commands { get; }
        ISingleSldWorks SwApp { get; }
        int Id { get; }

        #region Button

        ISwButton AddButton(string commandName);
        ISwButton AddButton(string commandName, string commandToolTop, DocumentTypes documentTypes);
        ISwButton AddButton(string commandName, string commandToolTop, DocumentTypes documentTypes, int ribbonOrder);
        ISwButton AddButton(string commandName, string commandToolTop, DocumentTypes documentTypes, int ribbonOrder, swCommandTabButtonTextDisplay_e ribbonDisplayType);
        //ISwButton AddButton(string commandName, string commandToolTop, DocumentTypes documentTypes, int ribbonOrder, swCommandTabButtonTextDisplay_e ribbonDisplayType, string menuName = "", int menuOrder = -1, CommandLocation menuType = CommandLocation.All);
        ISwButton AddButton(string commandName, string commandToolTop, DocumentTypes documentTypes, int ribbonOrder, swCommandTabButtonTextDisplay_e ribbonDisplayType, string menuName, int menuOrder, CommandLocation menuType, IIconDef icons);
        ISwButton AddButton(string commandName, string commandToolTop, DocumentTypes documentTypes = DocumentTypes.All, int ribbonOrder = -1, swCommandTabButtonTextDisplay_e ribbonDisplayType = swCommandTabButtonTextDisplay_e.swCommandTabButton_TextBelow, string menuName = "", int menuOrder = -1, CommandLocation menuType = CommandLocation.All);


        #endregion
        ISwFlyOut AddFlyOutGroup(string commandName);
        ISwFlyOut AddFlyOutGroup(string commandName,ISwFlyOutButton[] listOfButtons);

        
        //ISwFlyOutButton AddFlyoutButton(ISwFlyOut flyout, string commandName); - implement via flyout


    }
}
