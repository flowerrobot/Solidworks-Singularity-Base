using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Collections.Generic;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for IBomFeature
    /// </summary>
    public interface ISingleBomTable : ISingleTable

    {
        //new BomTable Table { get; } //This is an obsolete feature in SW
        IBomFeature TableFeature { get; }
        new IList<ISingleBomTableAnnotation> TableAnnotations { get; }
        ISingleView View { get; }

        /// <summary>
        /// Gets the number of configurations available to this BOM table or used in this BOM table. 
        /// </summary>
        /// <param name="onlyVisible">True to get the number of configurations currently displayed in this table, false to get the total number of configurations available in this table</param>
        /// <returns>Number of configurations in this BOM table or available to this BOM table</returns>
        int GetConfigurationCount(bool onlyVisible);
        /// <summary>
        /// Gets the configurations available to this BOM table or used in this BOM table. 
        /// </summary>
        /// <param name="onlyVisible">True to get the names of configurations currently displayed in this table, false to get the names of configurations available to this table</param>
        /// <param name="isVisible"></param>Array of BOOLEANs indicating the visibility of the configurations</param>
        /// <returns>Array of strings of the names of the configurations</returns>
        IList<string> GetConfigurations(bool onlyVisible, out IEnumerable<bool> isVisible);
        bool SetConfigurations(bool onlyVisible, IEnumerable<bool> visible, IEnumerable<string> configurations);

        string Configuration { get; }

        bool FollowAssemblyOrder { get; set; }
        ISingleModelDoc ReferencedModelName { get; }
        bool DetailedCutList { get; set; }
        bool DisplayAsOneItem { get; set; }
        bool KeepCurrentItemNumbers { get; set; }
        bool KeepMissingItems { get; set; }
        swKeepReplacedCompOption_e KeepReplacedCompOption { get; set; }
        swNumberingType_e NumberingTypeOnIndentedBom { get; set; }
        swPartConfigurationGroupingOption_e PartConfigurationGrouping { get; set; }
        swRoutingComponentGroupingOption_e RoutingComponentGrouping { get; set; }

        /// <summary>
        /// Number with which to start the numbering
        /// </summary>
        int SequenceStartNumber { get; set; }
        bool StrikeoutMissingItems { get; set; }
        swBomType_e TableDisplayType { get; }
        swZeroQuantityDisplay_e ZeroQuantityDisplay { get; set; }


    }

    /// <summary>
    /// Wrapper for IBomTableAnnotation
    /// </summary>
    public interface ISingleBomTableAnnotation : ISingleTableAnnotation
    {
        new ISingleBomTable Table { get; }
        new IBomTableAnnotation TableAnnotation { get; }

        //int TableAnnotationCount { get; }
        //IEnumerable<IBomTableAnnotation> TableAnnotations { get; }
        /// <summary>
        /// Will get sort data, or Will save, sort and apply as per documentation
        /// </summary>
        /// <returns></returns>
        BomTableSortData BomTableSortData { get; set; }
        new IList<ISingleBomColumn> Columns { get; }
        new IList<ISingleBomRow> Rows { get; }

        //bool Sort(BomTableSortData sortData);
        //bool ApplySavedSortScheme(BomTableSortData sortData);

    }

    public interface ISingleBomRow : ISingleTableRow
    {
        new ISingleBomTableAnnotation Annotation { get; }
        new IList<ISingleBomCell> Cells { get; }
        new IList<ISingleBomColumn> Columns { get; }

        IList<ISingleComponent> GetComponents(string configuration);
        IList<ISingleModelDoc> GetModelPathNames(out string itemNumber, out string partNumber);
        int GetComponentsCount(string configuration, out string itemNumber, out string partNumber);

        bool Dissolve();
        bool RestoreRestructuredComponents();

        string RowItemNumber { get; }
    }

    public interface ISingleBomColumn : ISingleTableColumn
    {
        new ISingleBomTableAnnotation Annotation { get; }


        string ColumnCustomProperty { get; set; }
        bool ColumnUseTitleAsPartNumber { get; set; }

        int GetAllCustomPropertiesCount { get; }
        IList<string> GetAllCustomProperties { get; }
    }

    public interface ISingleBomCell : ISingleTableCell
    {
        new ISingleBomTableAnnotation Annotation { get; }
        new ISingleBomColumn Column { get; }
        new ISingleBomRow Row { get; }
    }

#if false
    /// <summary>
    /// Wrapper for IBomFeature
    /// </summary>
    public interface ISingleBomTable<Ttable, Tanno, Trow, Tcol, Tcel>  :ISingleTable<Ttable, Tanno,Trow,Tcol,Tcel>
         where Trow : ISingleBomRow<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcol : ISingleBomColumn<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcel : ISingleBomCell<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tanno : ISingleBomTableAnnotation<Ttable, Tanno, Trow, Tcol, Tcel>
        where Ttable : ISingleBomTable<Ttable, Tanno, Trow, Tcol, Tcel>
    {
        //new BomTable Table { get; } //This is an obsolete feature in SW
        new IBomFeature TableFeature { get; }
        new IEnumerable<Tanno> TableAnnotations { get; }

        /// <summary>
        /// Gets the number of configurations available to this BOM table or used in this BOM table. 
        /// </summary>
        /// <param name="onlyVisible">True to get the number of configurations currently displayed in this table, false to get the total number of configurations available in this table</param>
        /// <returns>Number of configurations in this BOM table or available to this BOM table</returns>
        int GetConfigurationCount(bool onlyVisible);
        /// <summary>
        /// Gets the configurations available to this BOM table or used in this BOM table. 
        /// </summary>
        /// <param name="onlyVisible">True to get the names of configurations currently displayed in this table, false to get the names of configurations available to this table</param>
        /// <param name="isVisible"></param>Array of BOOLEANs indicating the visibility of the configurations</param>
        /// <returns>Array of strings of the names of the configurations</returns>
        IEnumerable<string> GetConfigurations(bool onlyVisible, out IEnumerable<bool> isVisible);
        bool SetConfigurations(bool onlyVisible, IEnumerable<bool> visible, IEnumerable<string> configurations);

        string Name { get; set; }
        string Configuration { get; }

        bool FollowAssemblyOrder { get; set; }
        ISingleModelDoc ReferencedModelName { get; }
        bool DetailedCutList { get; set; }
        bool DisplayAsOneItem { get; set; }
        bool KeepCurrentItemNumbers { get; set; }
        bool KeepMissingItems { get; set; }
        swKeepReplacedCompOption_e KeepReplacedCompOption { get; set; }
        swNumberingType_e NumberingTypeOnIndentedBom { get; set; }
        swPartConfigurationGroupingOption_e PartConfigurationGrouping { get; set; }
        swRoutingComponentGroupingOption_e RoutingComponentGrouping { get; set; }

        /// <summary>
        /// Number with which to start the numbering
        /// </summary>
        int SequenceStartNumber { get; set; }
        bool StrikeoutMissingItems { get; set; }
        swBomType_e TableDisplayType { get; }
        swZeroQuantityDisplay_e ZeroQuantityDisplay { get; set; }


    }
    /// <summary>
    /// Wrapper for IBomTableAnnotation
    /// </summary>
    public interface ISingleBomTableAnnotation<Ttable, Tanno, Trow, Tcol, Tcel> : ISingleTableAnnotation<Ttable, Tanno, Trow, Tcol, Tcel>
      where Trow : ISingleBomRow<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcol : ISingleBomColumn<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcel : ISingleBomCell<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tanno : ISingleBomTableAnnotation<Ttable, Tanno, Trow, Tcol, Tcel>
        where Ttable : ISingleBomTable<Ttable, Tanno, Trow, Tcol, Tcel>
    {
  
        new Ttable TableFeature { get; }
        new IBomTableAnnotation Annotation { get; }

        //int TableAnnotationCount { get; }
        //IEnumerable<IBomTableAnnotation> TableAnnotations { get; }

        new IEnumerable<Tcol> Columns { get; }
        new IEnumerable<Trow> Rows { get; }

        /// <summary>
        /// Will get sort data, or Will save, sort and apply as per documentation
        /// </summary>
        /// <returns></returns>
        BomTableSortData BomTableSortData { get; set; }

        //bool Sort(BomTableSortData sortData);
        //bool ApplySavedSortScheme(BomTableSortData sortData);

    }

    public interface ISingleBomCell<Ttable, Tanno, Trow, Tcol, Tcel>: ISingleTableCell<Ttable, Tanno, Trow, Tcol, Tcel>
      where Trow : ISingleBomRow<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcol : ISingleBomColumn<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcel : ISingleBomCell<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tanno : ISingleBomTableAnnotation<Ttable, Tanno, Trow, Tcol, Tcel>
        where Ttable : ISingleBomTable<Ttable, Tanno, Trow, Tcol, Tcel>
    {
    
       

    }

    public interface ISingleBomRow<Ttable, Tanno, Trow, Tcol, Tcel> : ISingleTableRow<Ttable, Tanno, Trow, Tcol, Tcel>
      where Trow : ISingleBomRow<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcol : ISingleBomColumn<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcel : ISingleBomCell<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tanno : ISingleBomTableAnnotation<Ttable, Tanno, Trow, Tcol, Tcel>
        where Ttable : ISingleBomTable<Ttable, Tanno, Trow, Tcol, Tcel>
    {

        new Tanno Table { get; }
        IEnumerable<Component2> GetComponents(string configuration);

        new IEnumerable<Tcel> Cells { get; }

        IEnumerable<ISingleModelDoc> GetModelPathNames(out string itemNumber, out string partNumber);
        int GetComponentsCount(string configuration, out string itemNumber, out string partNumber);

        bool Dissolve();
        bool RestoreRestructuredComponents();
    }

    public interface ISingleBomColumn<Ttable, Tanno, Trow, Tcol, Tcel> : ISingleTableColumn<Ttable, Tanno, Trow, Tcol, Tcel>
      where Trow : ISingleBomRow<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcol : ISingleBomColumn<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcel : ISingleBomCell<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tanno : ISingleBomTableAnnotation<Ttable, Tanno, Trow, Tcol, Tcel>
        where Ttable : ISingleBomTable<Ttable, Tanno, Trow, Tcol, Tcel>
    {
        new Tanno Table { get; }

        string ColumnCustomProperty { get; set; }
        bool ColumnUseTitleAsPartNumber { get; set; }

        int GetAllCustomPropertiesCount { get; }
        IEnumerable<string> GetAllCustomProperties { get; }
    }
#endif
}