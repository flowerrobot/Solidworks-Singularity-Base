using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;

namespace SingularityBase.Events
{

    #region Delegates
    /// <summary>
    /// Post-notifies the user program when the active window has changed. This change can be between windows of the same document or between windows of different documents.
    /// </summary>
    /// <param name="ActiveDocChangeNotifyEventHandler"></param>
    /// <param name=""></param>
    /// <returns></returns>
    public delegate EventResponse ActiveDocChangeNotifyEventHandler();

    /// <summary>
    /// Post-notifies the user program when the active IModelDoc2 object has changed. 
    /// </summary>
    /// <param name="ActiveModelDocChangeNotifyEventHandler"></param>
    /// <param name=""></param>
    /// <returns></returns>
    public delegate EventResponse ActiveModelDocChangeNotifyEventHandler();


    /// <summary>
    /// Fired when a command, including a PropertyManager page, is okay'd or canceled by a user. 
    /// </summary>
    /// <param name="CommandCloseNotifyEventHandler"></param>
    /// <param name=""></param>
    /// <param name="Command"></param>
    /// <param name=""></param>
    /// <param name="reason"></param>
    /// <returns></returns>
    public delegate EventResponse CommandCloseNotifyEventHandler(swCommands_e Command, swPropertyManagerPageCloseReasons_e reason);


    /// <summary>
    /// Fired before a command, including a PropertyManager page, executes or opens. 
    /// </summary>
    /// <param name="CommandOpenPreNotifyEventHandler"></param>
    /// <param name=""></param>
    /// <param name="Command"></param>
    /// <param name=""></param>
    /// <param name="UserCommand"></param>
    /// <returns></returns>
    public delegate EventResponse CommandOpenPreNotifyEventHandler(swCommands_e Command, int UserCommand);

    /// <summary>
    /// Post-notifies the user program when a SOLIDWORKS document is loaded.
    /// </summary>
    /// <param name="DocumentLoadNotify2EventHandler"></param>
    /// <param name=""></param>
    /// <param name="docTitle"></param>
    /// <param name=""></param>
    /// <param name="docPath"></param>
    /// <returns></returns>
    public delegate EventResponse DocumentLoadNotifyEventHandler(IDocumentEvent document);

    /// <summary>
    /// Notifies the user program when SOLIDWORKS is finished closing a file. 
    /// </summary>
    /// <param name="FileCloseNotifyEventHandler"></param>
    /// <param name=""></param>
    /// <param name="FileName"></param>
    /// <param name=""></param>
    /// <param name="reason"></param>
    /// <returns></returns>
    public delegate EventResponse FileCloseNotifyEventHandler(string FileName, swFileCloseNotifyReason_e reason);

    /// <summary>
    /// Post-notifies the user program when a new file is created.
    /// </summary>
    /// <param name="FileNewNotify2EventHandler"></param>
    /// <param name=""></param>
    /// <param name="NewDoc"></param>
    /// <param name=""></param>
    /// <param name="DocType"></param>
    /// <param name=""></param>
    /// <param name="TemplateName"></param>
    /// <returns></returns>
    public delegate EventResponse FileNewNotifyEventHandler(IDocumentEvent NewDoc, string TemplateName);

    /// <summary>
    /// Fired before a new document is created either using the SOLIDWORKS API or the SOLIDWORKS user-interface.
    /// </summary>
    /// <param name="FileNewPreNotifyEventHandler"></param>
    /// <param name=""></param>
    /// <param name="DocType"></param>
    /// <param name=""></param>
    /// <param name="TemplateName"></param>
    /// <returns></returns>
    public delegate EventResponse FileNewPreNotifyEventHandler(swDocumentTypes_e DocType, string TemplateName);

    /// <summary>
    /// Post-notifies the user program when an existing file has been opened. 
    /// </summary>
    /// <param name="FileOpenNotify2EventHandler"></param>
    /// <param name=""></param>
    /// <param name="FileName"></param>
    /// <returns></returns>
    public delegate EventResponse FileOpenNotifyEventHandler(IDocumentEvent newDoc);

    /// <summary>
    /// Post-notifies the user program when a file has been opened. 
    /// </summary>
    /// <param name="FileOpenPostNotifyEventHandler"></param>
    /// <param name=""></param>
    /// <param name="FileName"></param>
    /// <returns></returns>
    public delegate EventResponse FileOpenPostNotifyEventHandler(IDocumentEvent file);


    /// <summary>
    /// Pre-notifies the user program of a FileOpenNotify2 event. 
    /// </summary>
    /// <param name="FileOpenPreNotifyEventHandler"></param>
    /// <param name=""></param>
    /// <param name="FileName"></param>
    /// <returns></returns>
    public delegate EventResponse FileOpenPreNotifyEventHandler(string FileName);

    /// <summary>
    /// Notifies the user program before SOLIDWORKS starts searching for the specified referenced file.
    /// </summary>
    /// <param name="ReferencedFilePreNotifyEventHandler"></param>
    /// <param name=""></param>
    /// <param name="FileName"></param>
    /// <returns></returns>
    public delegate EventResponse ReferencedFilePreNotifyEventHandler(string FileName);


    /// <summary>
    /// Notifies the user program before the SOLIDWORKS software displays a dialog box prompting the end-user to browse for the referenced file.
    /// </summary>
    /// <param name="ReferenceNotFoundNotifyEventHandler"></param>
    /// <param name=""></param>
    /// <param name="FileName"></param>
    /// <returns></returns>
    public delegate void ReferenceNotFoundNotifyEventHandler(IMissingDocumentEvent e);


    /// <summary>
    /// Fired after all of the messages have been processed, included posted repaints; therefore, eliminating the need to call IModelDoc2::GraphicsRedraw2.
    /// </summary>
    /// <param name="OnIdleNotifyEventHandler"></param>
    /// <param name=""></param>
    /// <returns></returns>
    public delegate EventResponse OnIdleNotifyEventHandler();
    #endregion

    public interface ISolidWorksEvents
    {


        /// <summary>
        /// Post-notifies the user program when the active window has changed. This change can be between windows of the same document or between windows of different documents.
        /// </summary>
        /// <param name="ActiveDocChangeNotifyEventHandler"></param>
        /// <param name=""></param>
        /// <returns></returns>
        event ActiveDocChangeNotifyEventHandler ActiveDocChangeNotify;

        /// <summary>
        /// Post-notifies the user program when the active IModelDoc2 object has changed. 
        /// </summary>
        /// <param name="ActiveModelDocChangeNotifyEventHandler"></param>
        /// <param name=""></param>
        /// <returns></returns>
        event ActiveModelDocChangeNotifyEventHandler ActiveModelDocChange;


        /// <summary>
        /// Fired when a command, including a PropertyManager page, is okay'd or canceled by a user. 
        /// </summary>
        /// <param name="CommandCloseNotifyEventHandler"></param>
        /// <param name=""></param>
        /// <param name="Command"></param>
        /// <param name=""></param>
        /// <param name="reason"></param>
        /// <returns></returns>
        event CommandCloseNotifyEventHandler CommandClose;


        /// <summary>
        /// Fired before a command, including a PropertyManager page, executes or opens. 
        /// </summary>
        /// <param name="CommandOpenPreNotifyEventHandler"></param>
        /// <param name=""></param>
        /// <param name="Command"></param>
        /// <param name=""></param>
        /// <param name="UserCommand"></param>
        /// <returns></returns>
        event CommandOpenPreNotifyEventHandler CommandOpenPreNotify;

        /// <summary>
        /// Post-notifies the user program when a SOLIDWORKS document is loaded.
        /// </summary>
        /// <param name="DocumentLoadNotify2EventHandler"></param>
        /// <param name=""></param>
        /// <param name="docTitle"></param>
        /// <param name=""></param>
        /// <param name="docPath"></param>
        /// <returns></returns>
        event DocumentLoadNotifyEventHandler DocumentLoad;

        /// <summary>
        /// Notifies the user program when SOLIDWORKS is finished closing a file. 
        /// </summary>
        /// <param name="FileCloseNotifyEventHandler"></param>
        /// <param name=""></param>
        /// <param name="FileName"></param>
        /// <param name=""></param>
        /// <param name="reason"></param>
        /// <returns></returns>
        event FileCloseNotifyEventHandler FileClose;

        /// <summary>
        /// Post-notifies the user program when a new file is created.
        /// </summary>
        /// <param name="FileNewNotify2EventHandler"></param>
        /// <param name=""></param>
        /// <param name="NewDoc"></param>
        /// <param name=""></param>
        /// <param name="DocType"></param>
        /// <param name=""></param>
        /// <param name="TemplateName"></param>
        /// <returns></returns>
        event FileNewNotifyEventHandler FileNewNotify;

        /// <summary>
        /// Fired before a new document is created either using the SOLIDWORKS API or the SOLIDWORKS user-interface.
        /// </summary>
        /// <param name="FileNewPreNotifyEventHandler"></param>
        /// <param name=""></param>
        /// <param name="DocType"></param>
        /// <param name=""></param>
        /// <param name="TemplateName"></param>
        /// <returns></returns>
        event FileNewPreNotifyEventHandler FileNewPreNotify;

        /// <summary>
        /// Post-notifies the user program when an existing file has been opened. 
        /// </summary>
        /// <param name="FileOpenNotify2EventHandler"></param>
        /// <param name=""></param>
        /// <param name="FileName"></param>
        /// <returns></returns>
        event FileOpenNotifyEventHandler FileOpenNotify;

        /// <summary>
        /// Post-notifies the user program when a file has been opened. 
        /// </summary>
        /// <param name="FileOpenPostNotifyEventHandler"></param>
        /// <param name=""></param>
        /// <param name="FileName"></param>
        /// <returns></returns>
        event FileOpenPostNotifyEventHandler FileOpenPostNotify;


        /// <summary>
        /// Pre-notifies the user program of a FileOpenNotify2 event. 
        /// </summary>
        /// <param name="FileOpenPreNotifyEventHandler"></param>
        /// <param name=""></param>
        /// <param name="FileName"></param>
        /// <returns></returns>
        event FileOpenPreNotifyEventHandler FileOpenPreNotify;

        /// <summary>
        /// Notifies the user program before SOLIDWORKS starts searching for the specified referenced file.
        /// </summary>
        /// <param name="ReferencedFilePreNotifyEventHandler"></param>
        /// <param name=""></param>
        /// <param name="FileName"></param>
        /// <returns></returns>
        event ReferencedFilePreNotifyEventHandler ReferencedFilePreNotify;


        /// <summary>
        /// Notifies the user program before the SOLIDWORKS software displays a dialog box prompting the end-user to browse for the referenced file.
        /// </summary>
        /// <param name="ReferenceNotFoundNotifyEventHandler"></param>
        /// <param name=""></param>
        /// <param name="FileName"></param>
        /// <returns></returns>
        event ReferenceNotFoundNotifyEventHandler ReferenceNotFoundNotify;


        /// <summary>
        /// Fired after all of the messages have been processed, included posted repaints; therefore, eliminating the need to call IModelDoc2::GraphicsRedraw2.
        /// </summary>
        /// <param name="OnIdleNotifyEventHandler"></param>
        /// <param name=""></param>
        /// <returns></returns>
        event OnIdleNotifyEventHandler OnIdleNotify;
    }

    


    
}
