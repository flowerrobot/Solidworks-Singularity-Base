using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;

namespace SingularityBase.Events
{
    public delegate EventResponse AddCustomPropertyEventHandler(ISingleModelDoc doc,string propName, string configuration, string value, int valueType);
    public delegate EventResponse ChangeCustomPropertyEventHandler(ISingleModelDoc doc,string propName, string configuration, string oldValue, string newValue, int valueType);
    public delegate EventResponse DeleteCustomPropertyEventHandler(ISingleModelDoc doc,string propName, string configuration, string value, int valueType);


    public delegate EventResponse FileSavePreNotify(ISingleModelDoc doc,string filename);
    public delegate EventResponse FileSavePostNotify(ISingleModelDoc doc,int savetype, string filename);
    public delegate EventResponse FileSaveCancelledNotify(ISingleModelDoc doc);
    public delegate EventResponse FileSaveAsPreNotify(ISingleModelDoc doc,string filename);
    

    public delegate EventResponse ModifyTableNotifyHandler(ISingleModelDoc doc,ISingleTableAnnotation tableAnnotation, swTableAnnotationType_e tableType, swModifyTableNotifyReason_e reason, int rowInfo, int columnInfo, string dataInfo);
    public delegate EventResponse RegenPeNotifyHandler(ISingleModelDoc doc);
    public delegate EventResponse RegenPostNotifyHandler(ISingleModelDoc doc);

    public delegate EventResponse UserSelectionPostNotifyHandler(ISingleModelDoc doc);
    public delegate EventResponse UserSelectionPreNotifyHandler(ISingleModelDoc doc,swSelectType_e selType);
    public delegate EventResponse ClearSelectionsNotifyHandler(ISingleModelDoc doc);
    public delegate EventResponse NewSelectionPostNotifyHandler(ISingleModelDoc doc);
    public delegate EventResponse DeleteSelectionPreNotifyHandler(ISingleModelDoc doc);

    public interface IDocumentEvents : IDisposable
    {
        IModelDoc2 ModelDoc { get; }
        bool CanRaiseEvent { get; }

        #region Properties
        /// <summary>
        /// Post-notifies the user program when the user has added a custom property
        /// </summary>
        event AddCustomPropertyEventHandler CustomPropertyAdded;

        /// <summary>
        /// Post-notifies the user program when the user has changed a custom property.
        /// </summary>
        event ChangeCustomPropertyEventHandler CustomPropertyChanged;
        /// <summary>
        /// Post-notifies the user program when the user deletes a custom property.
        /// </summary>
        event DeleteCustomPropertyEventHandler CustomPropertyDeleted;
        #endregion
        #region Saving
        event FileSavePreNotify SavePreNotify;
        event FileSavePostNotify SavePostNotify;
        event FileSaveCancelledNotify SaveCancelledNotify;
        event FileSaveAsPreNotify SaveAsPreNotify;
        #endregion


        /// <summary>
        /// Notifies your program when a table has been modified in a drawing. 
        /// </summary>
        event ModifyTableNotifyHandler ModifyTableNotify;

        /// <summary>
        /// Pre-notifies the user program when a drawing document is about to be regenerated.
        /// </summary>
        event RegenPeNotifyHandler RegenPreNotify;

        /// <summary>
        /// Pre-notifies the user program when a drawing document is about to be regenerated.
        /// </summary>
        event RegenPostNotifyHandler RegenPostNotify;

        #region Selection
        /// <summary>
        /// Fired after an entity is selected in a drawing document. 
        /// </summary>
        event UserSelectionPostNotifyHandler UserSelectionPostNotify;

        /// <summary>
        /// Fired when an interactive user moves the cursor over or clicks a drawing view in a drawing document. 
        /// </summary>
        /// 
        event UserSelectionPreNotifyHandler UserSelectionPreNotify;

        /// <summary>
        /// Notifies the user program when selections are cleared using Clear Selections.
        /// </summary>
        /// 
        event ClearSelectionsNotifyHandler ClearSelectionsNotify;

        /// <summary>
        /// Post-notifies the user program when the selection list has changed.
        /// </summary>
        event NewSelectionPostNotifyHandler NewSelectionPostNotify;

        /// <summary>
        /// Pre-notifies the user program when the selection is deleted.
        /// </summary>
        event DeleteSelectionPreNotifyHandler DeleteSelectionPreNotify;
        #endregion


        IEventSupressor DisableEvents();

        Dictionary<int, IEventSupressor> Disables { get; }

    }
}
