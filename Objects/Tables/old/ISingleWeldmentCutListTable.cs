using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;

namespace SingularityBase.old
{
    /// <summary>
    /// Wrapper for IWeldmentCutListFeature 
    /// </summary>
    public interface ISingleWeldmentCutListTable : ISingleTable<ISingleWeldmentCutListTable, ISingleWeldmentCutListAnnotation, ISingleCutListRow, ISingleCutListColumn, ISingleCutListCell>, IDisposable

    {
        new IWeldmentCutListFeature TableFeature { get; }
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
    public interface ISingleWeldmentCutListAnnotation : ISingleTableAnnotation<ISingleWeldmentCutListTable, ISingleWeldmentCutListAnnotation, ISingleCutListRow, ISingleCutListColumn, ISingleCutListCell>, IDisposable

    {
        new IWeldmentCutListAnnotation TableAnnotation { get; }

        bool Sort(int columnIndex, bool sortAscending);
    }



    public interface ISingleCutListRow : ISingleTableRow<ISingleWeldmentCutListTable, ISingleWeldmentCutListAnnotation, ISingleCutListRow, ISingleCutListColumn, ISingleCutListCell>
    {
        new ISingleWeldmentCutListAnnotation Table { get; }
        new IEnumerable<ISingleCutListCell> Cells { get; }


    }

    public interface ISingleCutListColumn : ISingleTableColumn<ISingleWeldmentCutListTable, ISingleWeldmentCutListAnnotation, ISingleCutListRow, ISingleCutListColumn, ISingleCutListCell>
    {
        new ISingleWeldmentCutListAnnotation Table { get; }
        string ColumnCustomProperty { get; set; }

        int GetAllCustomPropertiesCount { get; }
        IEnumerable<string> GetAllCustomProperties { get; }
    }



    public interface ISingleCutListCell : ISingleTableCell<ISingleWeldmentCutListTable, ISingleWeldmentCutListAnnotation, ISingleCutListRow, ISingleCutListColumn, ISingleCutListCell>
    {
        new ISingleWeldmentCutListAnnotation Table { get; }
        new ISingleCutListColumn Column { get; }
        new ISingleCutListRow Row { get; }
    }






}


