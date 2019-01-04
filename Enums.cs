using SolidWorks.Interop.swconst;
using System;

namespace SingularityBase
{
    public enum IconEnabled : int
    {
        Deselect_Disable = 0,
        Deselect_Enable = 1,
        Select_Disable = 2,
        Select_Enable = 3,
        Hidden = 4
    }
    public enum EventPauseLevel : int
    {
        none = 0,
        All = 1,
        Document = 2
    }
    public enum EventStatus : int
    {
        EventsEnabled = 0,
        EventsDisabled = 1
    }
    public enum CommandType : int
    {
        Other = 0,
        Button = 1,
        FlyOut = 2,
        FlyoutSubButton = 3,
        Custom = 4

    }

    public enum SeperatorLocation
    {
        None = 0,
        // Before=1,
        After = 2
    }
    [Flags]
    public enum CommandLocation
    {
        None = 0,
        Menu = 1,
        ToolBar = 2,
        Ribbon = 4,
        All = Menu | ToolBar | Ribbon
    }

    [Flags]
    public enum DocumentTypes : int
    {
        Part = 1,
        Assembly = 2,
        Drawing = 4,
        All = Part | Assembly | Drawing
    }

    public enum CutListType_e
    {

        Unknown,
        StructuralMember,
        SheetMetal
    }

    public class FileExtensions
    {
        public const string Drawing = ".slddrw";
        public const string Part = ".sldprt";
        public const string Assembly = ".sldasm";
    }
    public enum EventLevel
    {
        ThisDocument,
        AllDocuments,
        SwEvents,
        All = SwEvents | AllDocuments | ThisDocument
    }

    public enum CustomPropertyType
    {
        Unkown,
        CustomProperty,
        ConfigurationCustomProperty,
        Cutlist
    }

    public static class EnumCompare
    {
        public static bool DocumentsEqual(this DocumentTypes s1, swDocumentTypes_e s2)
        {
            if (s1.HasFlag(DocumentTypes.Drawing) && s2 == swDocumentTypes_e.swDocDRAWING) return true;
            if (s1.HasFlag(DocumentTypes.Assembly) && s2 == swDocumentTypes_e.swDocASSEMBLY) return true;
            if (s1.HasFlag(DocumentTypes.Part) && s2 == swDocumentTypes_e.swDocPART) return true;

            return false;
        }
        public static bool DocumentsEqual(this swDocumentTypes_e s2, DocumentTypes s1)
        {
            return s1.DocumentsEqual(s2);
        }

    }

}
