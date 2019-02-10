using SolidWorks.Interop.sldworks;
using System.Collections.Generic;

namespace SingularityBase
{
    /// <summary>
    /// Wrapper for IWeldmentCutListFeature 
    /// </summary>
    public interface ISingleWeldmentCutListTable : ISingleTable, ISingleFeature

    {
        IWeldmentCutListFeature TableFeature { get; }
        new IList<ISingleWeldmentCutListAnnotation> TableAnnotations { get; }
        ISingleView View { get; }

        string Configuration { get; set; }
        bool KeepCurrentItemNumbers { get; set; }
        bool KeepMissingItems { get; set; }
        int SequenceStartNumber { get; set; }
        bool StrikeoutMissingItems { get; set; }
    }

    /// <summary>
    /// Wrapper for IWeldmentCutListAnnotation 
    /// </summary>
    public interface ISingleWeldmentCutListAnnotation : ISingleTableAnnotation

    {
        new IWeldmentCutListAnnotation TableAnnotation { get; }
        new IList<ISingleCutListColumn> Columns { get; }
        new IList<ISingleCutListRow> Rows { get; }

        bool Sort(int columnIndex, bool sortAscending);


    }



    public interface ISingleCutListRow : ISingleTableRow
    {
        new ISingleWeldmentCutListAnnotation Annotation { get; }
        new IList<ISingleCutListCell> Cells { get; }
        new IList<ISingleCutListColumn> Columns { get; }
    }

    public interface ISingleCutListColumn : ISingleTableColumn
    {
        new ISingleWeldmentCutListAnnotation Annotation { get; }
        string ColumnCustomProperty { get; set; }

        int GetAllCustomPropertiesCount { get; }
        IList<string> GetAllCustomProperties { get; }
    }



    public interface ISingleCutListCell : ISingleTableCell
    {
        new ISingleWeldmentCutListAnnotation Annotation { get; }
        new ISingleCutListColumn Column { get; }
        new ISingleCutListRow Row { get; }
    }






}


