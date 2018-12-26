using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        Ribbion = 4,
        All = Menu | ToolBar | Ribbion
    }

    [Flags]
    public enum DocumentTypes : int
    {
        Part = 1,
        Assembly = 2,
        Drawing = 3,
        All = Part | Assembly | Drawing
    }

    public enum CutListType_e
    {

        Unknown,
        StructuralMember,

        SheetMetal,
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
}
