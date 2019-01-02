using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SingularityBase.UI
{
    public interface IMenuCollection  :IDisposable
    {
        int Id { get; }
        string MenuName { get; }

        ReadOnlyCollection<ISwMenu> Commands { get; }
        ICommandGroup CmdGroup { get; }

       ReadOnlyCollection<IMenuCollection> SubMenus { get; }
    }
}
