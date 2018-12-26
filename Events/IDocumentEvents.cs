using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase.Events
{
    public delegate int AddCustomPropertyEventHandler(string propName, string configuration, string value, int valueType);
    public delegate int ChangeCustomPropertyEventHandler(string propName, string configuration, string oldValue, string NewValue, int valueType);
    public delegate int DeleteCustomPropertyEventHandler(string propName, string configuration, string value, int valueType);


    public delegate int RegenPostNotifyEventHandler();

    public delegate int FileSavePreNotify(string filename);
    public delegate int FileSavePostNotify(int savetype, string filename);
    public delegate int FileSaveCancelledNotify();
    public delegate int FileSaveAsPreNotify(string filename);
    public interface IDocumentEvents : IDisposable
    {
        IModelDoc2 Document { get; }
        bool CanRaiseEvent { get; }

        #region Properties
        event AddCustomPropertyEventHandler AddCustomProperty;
        event ChangeCustomPropertyEventHandler ChangeCustomProperty;
        event DeleteCustomPropertyEventHandler DeleteCustomProperty;
        #endregion

        event RegenPostNotifyEventHandler RegenPostNotify;

        #region Saving
        event FileSavePreNotify SavePreNotify;
        event FileSavePostNotify SavePostNotify;
        event FileSaveCancelledNotify SaveCancelledNotify;
        event FileSaveAsPreNotify SaveAsPreNotify;
        #endregion

        IEventSupressor DisableEvents();

        Dictionary<int, IEventSupressor> Disables { get; }

    }
}
