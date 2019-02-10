using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;

namespace SingularityBase.Events
{
#if false
    private class partDocs : DPartDocEvents {

        public int DestroyNotify()
        {
            throw new NotImplementedException();
        }

       

        public int ViewNewNotify()
        {
            throw new NotImplementedException();
        }


     
        public int LoadFromStorageNotify()
        {
            throw new NotImplementedException();
        }

        public int SaveToStorageNotify()
        {
            throw new NotImplementedException();
        }

        public int ActiveConfigChangeNotify()
        {
            throw new NotImplementedException();
        }

        public int ActiveConfigChangePostNotify()
        {
            throw new NotImplementedException();
        }

        public int ViewNewNotify2(object viewBeingAdded)
        {
            throw new NotImplementedException();
        }

        public int LightingDialogCreateNotify(object dialog)
        {
            throw new NotImplementedException();
        }

        public int AddItemNotify(int EntityType, string itemName)
        {
            throw new NotImplementedException();
        }

        public int RenameItemNotify(int EntityType, string oldName, string NewName)
        {
            throw new NotImplementedException();
        }

        public int DeleteItemNotify(int EntityType, string itemName)
        {
            throw new NotImplementedException();
        }

        public int ModifyNotify()
        {
            throw new NotImplementedException();
        }

        public int FileReloadNotify()
        {
            throw new NotImplementedException();
        }

        public int FeatureEditPreNotify(object EditFeature)
        {
            throw new NotImplementedException();
        }

        public int FeatureSketchEditPreNotify(object EditFeature, object featureSketch)
        {
            throw new NotImplementedException();
        }


     
        public int FileReloadPreNotify()
        {
            throw new NotImplementedException();
        }

        public int BodyVisibleChangeNotify()
        {
            throw new NotImplementedException();
        }

        public int RegenPostNotify2(object stopFeature)
        {
            throw new NotImplementedException();
        }

 

        public int LoadFromStorageStoreNotify()
        {
            throw new NotImplementedException();
        }

        public int SaveToStorageStoreNotify()
        {
            throw new NotImplementedException();
        }

        public int FeatureManagerTreeRebuildNotify()
        {
            throw new NotImplementedException();
        }

        public int FileDropPostNotify(string FileName)
        {
            throw new NotImplementedException();
        }

        public int DynamicHighlightNotify(bool bHighlightState)
        {
            throw new NotImplementedException();
        }

        public int DimensionChangeNotify(object displayDim)
        {
            throw new NotImplementedException();
        }

        public int FileReloadCancelNotify(int ErrorCode)
        {
            throw new NotImplementedException();
        }

      

        public int SketchSolveNotify(string featName)
        {
            throw new NotImplementedException();
        }

        public int DeleteItemPreNotify(int EntityType, string itemName)
        {
            throw new NotImplementedException();
        }

     

        public int EquationEditorPreNotify()
        {
            throw new NotImplementedException();
        }

        public int EquationEditorPostNotify(bool Changed)
        {
            throw new NotImplementedException();
        }

        public int OpenDesignTableNotify(object DesignTable)
        {
            throw new NotImplementedException();
        }

        public int CloseDesignTableNotify(object DesignTable)
        {
            throw new NotImplementedException();
        }

        public int PromptBodiesToKeepNotify(object Feature, ref object Bodies)
        {
            throw new NotImplementedException();
        }

        public int AddDvePagePreNotify(int Command, ref object PageToAdd)
        {
            throw new NotImplementedException();
        }

        public int UnitsChangeNotify()
        {
            throw new NotImplementedException();
        }

        public int DestroyNotify2(int DestroyType)
        {
            throw new NotImplementedException();
        }

        public int ConfigurationChangeNotify(string ConfigurationName, object Object, int ObjectType, int changeType)
        {
            throw new NotImplementedException();
        }

        public int SuppressionStateChangeNotify(Feature Feature, int NewSuppressionState, int PreviousSuppressionState,
            int ConfigurationOption, ref object ConfigurationNames)
        {
            throw new NotImplementedException();
        }

        public int ActiveViewChangeNotify()
        {
            throw new NotImplementedException();
        }

        public int FeatureManagerFilterStringChangeNotify(string FilterString)
        {
            throw new NotImplementedException();
        }

        public int FlipLoopNotify(object TheLoop, object TheEdge)
        {
            throw new NotImplementedException();
        }

        public int AutoSaveNotify(string FileName)
        {
            throw new NotImplementedException();
        }

        public int AutoSaveToStorageNotify()
        {
            throw new NotImplementedException();
        }

        public int FileDropPreNotify(string FileName)
        {
            throw new NotImplementedException();
        }

        public int SensorAlertPreNotify(object SensorIn, int SensorAlertType)
        {
            throw new NotImplementedException();
        }

        public int UndoPostNotify()
        {
            throw new NotImplementedException();
        }


        public int ActiveDisplayStateChangePreNotify()
        {
            throw new NotImplementedException();
        }

        public int ActiveDisplayStateChangePostNotify(string DisplayStateName)
        {
            throw new NotImplementedException();
        }

        public int RedoPostNotify()
        {
            throw new NotImplementedException();
        }

        public int RedoPreNotify()
        {
            throw new NotImplementedException();
        }

        public int UndoPreNotify()
        {
            throw new NotImplementedException();
        }

        public int WeldmentCutListUpdatePostNotify()
        {
            throw new NotImplementedException();
        }

        public int AutoSaveToStorageStoreNotify()
        {
            throw new NotImplementedException();
        }

        public int DragStateChangeNotify(bool State)
        {
            throw new NotImplementedException();
        }

        public int InsertTableNotify(TableAnnotation TableAnnotation, int TableType, string TemplatePath)
        {
            throw new NotImplementedException();
        }

     

        public int CommandManagerTabActivatedPreNotify(int CommandTabIndex, string CommandTabName)
        {
            throw new NotImplementedException();
        }

        public int PreRenameItemNotify(int EntityType, string oldName, string NewName)
        {
            throw new NotImplementedException();
        }

        public int RenamedDocumentNotify(ref object RenamedDocumentInterface)
        {
            throw new NotImplementedException();
        }

        public int FeatureManagerTabActivatedPreNotify(int CommandIndex, string CommandTabName)
        {
            throw new NotImplementedException();
        }

        public int FeatureManagerTabActivatedNotify(int CommandIndex, string CommandTabName)
        {
            throw new NotImplementedException();
        }

        public int PublishTo3DPDFNotify(string Path)
        {
            throw new NotImplementedException();
        }
    }
    private class assDocs : DAssemblyDocEvents
    {
       

        public int DestroyNotify()
        {
            throw new NotImplementedException();
        }


        public int ViewNewNotify()
        {
            throw new NotImplementedException();
        }

  


  

        public int LoadFromStorageNotify()
        {
            throw new NotImplementedException();
        }

        public int SaveToStorageNotify()
        {
            throw new NotImplementedException();
        }

        public int ActiveConfigChangeNotify()
        {
            throw new NotImplementedException();
        }

        public int ActiveConfigChangePostNotify()
        {
            throw new NotImplementedException();
        }

        public int BeginInContextEditNotify(object docBeingEdited, int DocType)
        {
            throw new NotImplementedException();
        }

        public int EndInContextEditNotify(object docBeingEdited, int DocType)
        {
            throw new NotImplementedException();
        }

        public int ViewNewNotify2(object viewBeingAdded)
        {
            throw new NotImplementedException();
        }

        public int LightingDialogCreateNotify(object dialog)
        {
            throw new NotImplementedException();
        }

        public int AddItemNotify(int EntityType, string itemName)
        {
            throw new NotImplementedException();
        }

        public int RenameItemNotify(int EntityType, string oldName, string NewName)
        {
            throw new NotImplementedException();
        }

        public int DeleteItemNotify(int EntityType, string itemName)
        {
            throw new NotImplementedException();
        }

        public int ModifyNotify()
        {
            throw new NotImplementedException();
        }

        public int ComponentStateChangeNotify(object componentModel, short oldCompState, short newCompState)
        {
            throw new NotImplementedException();
        }

        public int FileDropNotify(string FileName)
        {
            throw new NotImplementedException();
        }

        public int FileReloadNotify()
        {
            throw new NotImplementedException();
        }

        public int ComponentStateChangeNotify2(object componentModel, string CompName, short oldCompState, short newCompState)
        {
            throw new NotImplementedException();
        }


        public int ChangeCustomPropertyNotify(string propName, string Configuration, string oldValue, string NewValue, int valueType)
        {
            throw new NotImplementedException();
        }

        public int FeatureEditPreNotify(object EditFeature)
        {
            throw new NotImplementedException();
        }

        public int FeatureSketchEditPreNotify(object EditFeature, object featureSketch)
        {
            throw new NotImplementedException();
        }

     

        public int InterferenceNotify(ref object PComp, ref object PFace)
        {
            throw new NotImplementedException();
        }


        public int FileReloadPreNotify()
        {
            throw new NotImplementedException();
        }

        public int ComponentMoveNotify()
        {
            throw new NotImplementedException();
        }

        public int ComponentVisibleChangeNotify()
        {
            throw new NotImplementedException();
        }

        public int BodyVisibleChangeNotify()
        {
            throw new NotImplementedException();
        }

        public int FileDropPreNotify(string FileName)
        {
            throw new NotImplementedException();
        }

     

        public int LoadFromStorageStoreNotify()
        {
            throw new NotImplementedException();
        }

        public int SaveToStorageStoreNotify()
        {
            throw new NotImplementedException();
        }

        public int FeatureManagerTreeRebuildNotify()
        {
            throw new NotImplementedException();
        }

        public int AssemblyElectricalDataUpdateNotify(int saveType)
        {
            throw new NotImplementedException();
        }

        public int ComponentMoveNotify2(ref object Components)
        {
            throw new NotImplementedException();
        }

        public int DynamicHighlightNotify(bool bHighlightState)
        {
            throw new NotImplementedException();
        }

        public int ComponentVisualPropertiesChangeNotify(object Component)
        {
            throw new NotImplementedException();
        }

        public int ComponentDisplayStateChangeNotify(object Component)
        {
            throw new NotImplementedException();
        }

        public int DimensionChangeNotify(object displayDim)
        {
            throw new NotImplementedException();
        }

        public int FileReloadCancelNotify(int ErrorCode)
        {
            throw new NotImplementedException();
        }

        

        public int SketchSolveNotify(string featName)
        {
            throw new NotImplementedException();
        }

        public int DeleteItemPreNotify(int EntityType, string itemName)
        {
            throw new NotImplementedException();
        }

     

        public int FileDropPostNotify()
        {
            throw new NotImplementedException();
        }

        public int EquationEditorPreNotify()
        {
            throw new NotImplementedException();
        }

        public int EquationEditorPostNotify(bool Changed)
        {
            throw new NotImplementedException();
        }

        public int OpenDesignTableNotify(object DesignTable)
        {
            throw new NotImplementedException();
        }

        public int CloseDesignTableNotify(object DesignTable)
        {
            throw new NotImplementedException();
        }

        public int PromptBodiesToKeepNotify(object Feature, ref object Bodies)
        {
            throw new NotImplementedException();
        }

        public int AddDvePagePreNotify(int Command, ref object PageToAdd)
        {
            throw new NotImplementedException();
        }

        public int UnitsChangeNotify()
        {
            throw new NotImplementedException();
        }

        public int DestroyNotify2(int DestroyType)
        {
            throw new NotImplementedException();
        }


        public int ComponentReorganizeNotify(string sourceName, string targetName)
        {
            throw new NotImplementedException();
        }

        public int SuppressionStateChangeNotify(Feature Feature, int NewSuppressionState, int PreviousSuppressionState,
            int ConfigurationOption, ref object ConfigurationNames)
        {
            throw new NotImplementedException();
        }

        public int ActiveViewChangeNotify()
        {
            throw new NotImplementedException();
        }

        public int FeatureManagerFilterStringChangeNotify(string FilterString)
        {
            throw new NotImplementedException();
        }

        public int FlipLoopNotify(object TheLoop, object TheEdge)
        {
            throw new NotImplementedException();
        }

        public int AutoSaveNotify(string FileName)
        {
            throw new NotImplementedException();
        }

        public int AutoSaveToStorageNotify()
        {
            throw new NotImplementedException();
        }

        public int SensorAlertPreNotify(object SensorIn, int SensorAlertType)
        {
            throw new NotImplementedException();
        }

        public int ActiveDisplayStateChangePreNotify()
        {
            throw new NotImplementedException();
        }

        public int ActiveDisplayStateChangePostNotify(string DisplayStateName)
        {
            throw new NotImplementedException();
        }

        public int AddMatePostNotify()
        {
            throw new NotImplementedException();
        }

        public int ComponentConfigurationChangeNotify(string componentName, string oldConfigurationName, string newConfigurationName)
        {
            throw new NotImplementedException();
        }

        public int UndoPostNotify()
        {
            throw new NotImplementedException();
        }


        public int RedoPostNotify()
        {
            throw new NotImplementedException();
        }

        public int RedoPreNotify()
        {
            throw new NotImplementedException();
        }

        public int UndoPreNotify()
        {
            throw new NotImplementedException();
        }

        public int ComponentReferredDisplayStateChangeNotify(object componentModel, string CompName, int oldDSId, string oldDSName,
            int newDSId, string newDSName)
        {
            throw new NotImplementedException();
        }

        public int SelectiveOpenPostNotify(string NewAddedDisplayStateName, ref object SelectedComponentNames)
        {
            throw new NotImplementedException();
        }

        public int RegenPostNotify2(object stopFeature)
        {
            throw new NotImplementedException();
        }

        public int AutoSaveToStorageStoreNotify()
        {
            throw new NotImplementedException();
        }

        public int DragStateChangeNotify(bool State)
        {
            throw new NotImplementedException();
        }

        public int InsertTableNotify(TableAnnotation TableAnnotation, string TableType, string TemplatePath)
        {
            throw new NotImplementedException();
        }

    


        public int ComponentDisplayModeChangePreNotify(object Component)
        {
            throw new NotImplementedException();
        }

        public int ComponentDisplayModeChangePostNotify(object Component)
        {
            throw new NotImplementedException();
        }

        public int CommandManagerTabActivatedPreNotify(int CommandTabIndex, string CommandTabName)
        {
            throw new NotImplementedException();
        }

        public int PreRenameItemNotify(int EntityType, string oldName, string NewName)
        {
            throw new NotImplementedException();
        }

        public int RenamedDocumentNotify(ref object RenamedDocumentInterface)
        {
            throw new NotImplementedException();
        }

        public int FeatureManagerTabActivatedPreNotify(int CommandIndex, string CommandTabName)
        {
            throw new NotImplementedException();
        }

        public int FeatureManagerTabActivatedNotify(int CommandIndex, string CommandTabName)
        {
            throw new NotImplementedException();
        }

        public int PublishTo3DPDFNotify(string Path)
        {
            throw new NotImplementedException();
        }
    }
    private class ddocs : DDrawingDocEvents
    {
 

        public int DestroyNotify()
        {
            throw new System.NotImplementedException();
        }

        public int ViewNewNotify()
        {
            throw new System.NotImplementedException();
        }

    

   

      

        public int LoadFromStorageNotify()
        {
            throw new System.NotImplementedException();
        }

        public int SaveToStorageNotify()
        {
            throw new System.NotImplementedException();
        }

        public int ActiveConfigChangeNotify()
        {
            throw new System.NotImplementedException();
        }

        public int ActiveConfigChangePostNotify()
        {
            throw new System.NotImplementedException();
        }

        public int ViewNewNotify2(object viewBeingAdded)
        {
            throw new System.NotImplementedException();
        }

        public int AddItemNotify(int EntityType, string itemName)
        {
            throw new System.NotImplementedException();
        }

        public int RenameItemNotify(int EntityType, string oldName, string NewName)
        {
            throw new System.NotImplementedException();
        }

        public int DeleteItemNotify(int EntityType, string itemName)
        {
            throw new System.NotImplementedException();
        }

        public int ModifyNotify()
        {
            throw new System.NotImplementedException();
        }

        public int FileReloadNotify()
        {
            throw new System.NotImplementedException();
        }
        

        public int FileReloadPreNotify()
        {
            throw new System.NotImplementedException();
        }

   

        public int LoadFromStorageStoreNotify()
        {
            throw new System.NotImplementedException();
        }

        public int SaveToStorageStoreNotify()
        {
            throw new System.NotImplementedException();
        }

        public int FeatureManagerTreeRebuildNotify()
        {
            throw new System.NotImplementedException();
        }

      

        public int DynamicHighlightNotify(bool bHighlightState)
        {
            throw new System.NotImplementedException();
        }

        public int DimensionChangeNotify(object displayDim)
        {
            throw new System.NotImplementedException();
        }

        public int FileReloadCancelNotify(int ErrorCode)
        {
            throw new System.NotImplementedException();
        }


        public int SketchSolveNotify(string featName)
        {
            throw new System.NotImplementedException();
        }

        public int DeleteItemPreNotify(int EntityType, string itemName)
        {
            throw new System.NotImplementedException();
        }

   

        public int EquationEditorPreNotify()
        {
            throw new System.NotImplementedException();
        }

        public int EquationEditorPostNotify(bool Changed)
        {
            throw new System.NotImplementedException();
        }

        public int AddDvePagePreNotify(int Command, ref object PageToAdd)
        {
            throw new System.NotImplementedException();
        }

        public int UnitsChangeNotify()
        {
            throw new System.NotImplementedException();
        }

        public int DestroyNotify2(int DestroyType)
        {
            throw new System.NotImplementedException();
        }

        public int AutoSaveNotify(string FileName)
        {
            throw new System.NotImplementedException();
        }

        public int AutoSaveToStorageNotify()
        {
            throw new System.NotImplementedException();
        }

        public int UndoPostNotify()
        {
            throw new System.NotImplementedException();
        }

      

        public int RedoPostNotify()
        {
            throw new System.NotImplementedException();
        }

        public int RedoPreNotify()
        {
            throw new System.NotImplementedException();
        }

        public int UndoPreNotify()
        {
            throw new System.NotImplementedException();
        }

        public int AutoSaveToStorageStoreNotify()
        {
            throw new System.NotImplementedException();
        }

        public int InsertTableNotify(TableAnnotation TableAnnotation, string TableType, string TemplatePath)
        {
            throw new System.NotImplementedException();
        }

        

        public int ActivateSheetPreNotify(string SheetName)
        {
            throw new System.NotImplementedException();
        }

        public int ActivateSheetPostNotify(string SheetName)
        {
            throw new System.NotImplementedException();
        }

        public int CommandManagerTabActivatedPreNotify(int CommandTabIndex, string CommandTabName)
        {
            throw new System.NotImplementedException();
        }

        public int FeatureManagerTabActivatedPreNotify(int CommandIndex, string CommandTabName)
        {
            throw new System.NotImplementedException();
        }

        public int FeatureManagerTabActivatedNotify(int CommandIndex, string CommandTabName)
        {
            throw new System.NotImplementedException();
        }
    }
#endif
}
