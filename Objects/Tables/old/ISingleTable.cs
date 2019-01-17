
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;

namespace SingularityBase.old
{
    //This is generic for all tables
    public interface ISingleTable<Ttable, Tanno, Trow, Tcol, Tcel> : IDisposable 
        where Trow : ISingleTableRow<Ttable, Tanno, Trow, Tcol, Tcel> 
        where Tcol : ISingleTableColumn<Ttable, Tanno, Trow, Tcol, Tcel> 
        where Tcel : ISingleTableCell<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tanno : ISingleTableAnnotation<Ttable, Tanno, Trow, Tcol, Tcel>
        where Ttable : ISingleTable<Ttable, Tanno, Trow, Tcol, Tcel>
    {
        ISingleModelDoc Document { get; }
        ISingleFeature Feature { get; }
         object TableFeature { get; }

        IEnumerable<Tanno> TableAnnotations { get; } //IGeneralTableAnnotation 

        //TODO add events for when things change on the UI
    }

    /// <summary>
    /// Wrapper for ITableAnnotation
    /// This is the basis for any table in SW
    /// </summary>
    public interface ISingleTableAnnotation<Ttable, Tanno, Trow, Tcol, Tcel> : IDisposable
         where Trow : ISingleTableRow<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcol : ISingleTableColumn<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcel : ISingleTableCell<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tanno : ISingleTableAnnotation<Ttable, Tanno, Trow, Tcol, Tcel>
        where Ttable : ISingleTable<Ttable, Tanno, Trow, Tcol, Tcel>
    {

        Ttable TableFeature { get; }

        ITableAnnotation TableAnnotation { get; }
        /// <summary>
        /// Gets the annotation for this table annotation. 
        /// </summary>
        ISingleAnnotation GetAnnotation { get; }
        swTableAnnotationType_e TableType { get; }

        IEnumerable<Tcol> Columns { get; }
        IEnumerable<Trow> Rows { get; }

        bool DeleteColumn(int index);
        bool DeleteRow(int index);

        #region wrapper
        //      TableAnnotation GetNext();
        //      Annotation GetAnnotation();


        bool UseDocTextFormat { get; set; }
        /// <summary>
        /// Set to null to use document format
        /// </summary>
        TextFormat GetTextFormat { get; set; }

        int HeaderCount { get; set; }
        swTableHeaderPosition_e HeaderStyle { get; set; }


        swTableSplitDirection_e GetSplitInformation(out int Index, out int Count, out int RangeStart, out int RangeEnd);
        TableAnnotation Split(swTableSplitLocations_e Where, int Index);
        bool Merge(swTableMergeLocations_e where);

        bool InsertColumn(swTableItemInsertPosition_e where, int Index, string Name, swInsertTableColumnWidthStyle_e WidthStyle);
        bool InsertRow(swTableItemInsertPosition_e Where, int Index);

        bool MoveColumn(Tcol Source, swTableItemInsertPosition_e Where, Tcol Destination);
        bool MoveRow(Trow Source, swTableItemInsertPosition_e Where, Trow Destination);


        //void GetCellRange(out int FirstRow, out int LastRow, out int FirstColumn, out int LastColumn);
        //void SetCellRange(int FirstRow, int LastRow, int FirstColumn, int LastColumn);

        bool SaveAsTemplate(string FileName);
        bool SaveAsText(string FileName, string Separator);


        bool SaveAsPdf(string fileName);
        object HorizontalAutoSplit(int MaxNumberOfRows, swHorizontalAutoSplitApply_e Apply, swHorizontalAutoSplitPlacementOfSplitTable_e PlacementOfNewSplitTables);


        swTableAnnotationType_e Type { get; }
        int BorderLineWeight { get; set; }
        int GridLineWeight { get; set; }
        swBOMConfigurationAnchorType_e AnchorType { get; set; }
        swTextAlignmentVertical_e TextVerticalJustification { get; set; }
        swTextJustification_e TextHorizontalJustification { get; set; }
        int ColumnCount { get; }
        int RowCount { get; }

        string Title { get; set; }
        bool TitleVisible { get; set; }
        bool Anchored { get; set; }


        double BorderLineWeightCustom { get; set; }
        double GridLineWeightCustom { get; set; }

        bool StopAutoSplitting { get; set; }
        #endregion
    }

    public interface ISingleTableRow<Ttable, Tanno, Trow, Tcol, Tcel>
     where Trow : ISingleTableRow<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcol : ISingleTableColumn<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcel : ISingleTableCell<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tanno : ISingleTableAnnotation<Ttable, Tanno, Trow, Tcol, Tcel>
        where Ttable : ISingleTable<Ttable, Tanno, Trow, Tcol, Tcel>
    {
       Tanno Table { get; }
        IEnumerable<Tcol> Columns { get; }
        IEnumerable<Tcel> Cells { get; }

        double GetRowHeight();
        double SetRowHeight(double height, swTableRowColSizeChangeBehavior_e Options);
        double RowVerticalGap { get; set; }
        bool LockRowHeight { get; set; }
        bool RowHidden { get; set; }

        int RowIndex { get; }

        bool DeleteRow();
    }

    public interface ISingleTableColumn<Ttable, Tanno, Trow, Tcol, Tcel>
     where Trow : ISingleTableRow<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcol : ISingleTableColumn<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcel : ISingleTableCell<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tanno : ISingleTableAnnotation<Ttable, Tanno, Trow, Tcol, Tcel>
        where Ttable : ISingleTable<Ttable, Tanno, Trow, Tcol, Tcel>
    {
        Tanno Table { get; }
        IEnumerable<Trow> Rows { get; }

        double GetColumnWidth { get; }
        double SetColumnWidth(double width, swTableRowColSizeChangeBehavior_e options);

        swTableColumnTypes_e GetColumnType { get; set; }
        string GetColumnTitle { get; set; }
        bool GetLockColumnWidth { get; set; }
        bool ColumnHidden { get; set; }

        int ColumnIndex { get; }

        bool DeleteColumn();

    }

    public interface ISingleTableCell<Ttable, Tanno, Trow, Tcol, Tcel>
     where Trow : ISingleTableRow<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcol : ISingleTableColumn<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tcel : ISingleTableCell<Ttable, Tanno, Trow, Tcol, Tcel>
        where Tanno : ISingleTableAnnotation<Ttable, Tanno, Trow, Tcol, Tcel>
        where Ttable : ISingleTable<Ttable, Tanno, Trow, Tcol, Tcel>
    {
        Tanno Table { get; }
        Tcol Column { get; }
        Trow Row { get; }


        bool CellUseDocTextFormat { get; set; }
        //Set to null to use doc text format
        TextFormat CellTextFormat { get; set; }


        bool MergeCells(Trow rowEnd, Tcol columnEnd);
        bool UnMergeCells();


        bool IsCellMerged { get; }
        bool IsCellTextEditable { get; }
        string Text { get; set; }
        string DisplayedText { get; }

        swTextJustification_e TextHorizontalJustification { get; set; }
        swTextAlignmentVertical_e TextVerticalJustification { get; set; }

    }
}




#if false
using System;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Collections.Generic;

namespace SingularityBase
{
    //This is generic for all tables
    public interface ISingleTable : IDisposable
    {
        ISingleModelDoc Document { get; }
        ISingleFeature Feature { get; }
        object TableFeature { get; }

        IEnumerable<ISingleTableAnnotation> TableAnnotations { get; } //IGeneralTableAnnotation 
    }
    /// <summary>
    /// Wrapper for ITableAnnotation
    /// This is the basis for any table in SW
    /// </summary>
    public interface ISingleTableAnnotation<T,T2,T3> : IDisposable where T:ISingleTableRow where T2:ISingleTableColumn where T3:ISingleTableCell
    {

        ISingleTable TableFeature { get; }


        ITableAnnotation Annotation { get; }
        swTableAnnotationType_e TableType { get; }

        IEnumerable<T2> Columns { get; }
        IEnumerable<T> Rows { get; }

        bool DeleteColumn(int index);
        bool DeleteRow(int index);

#region wrapper
        //      TableAnnotation GetNext();
        //      Annotation GetAnnotation();


        bool UseDocTextFormat { get; set; }
        /// <summary>
        /// Set to null to use document format
        /// </summary>
        TextFormat GetTextFormat { get; set; }

        int HeaderCount { get; set; }
        swTableHeaderPosition_e HeaderStyle { get; set; }


        swTableSplitDirection_e GetSplitInformation(out int Index, out int Count, out int RangeStart, out int RangeEnd);
        TableAnnotation Split(swTableSplitLocations_e Where, int Index);
        bool Merge(swTableMergeLocations_e where);

        bool InsertColumn(swTableItemInsertPosition_e where, int Index, string Name, swInsertTableColumnWidthStyle_e WidthStyle);
        bool InsertRow(swTableItemInsertPosition_e Where, int Index);

        bool MoveColumn(ISingleTableColumn Source, swTableItemInsertPosition_e Where, ISingleTableColumn Destination);
        bool MoveRow(ISingleTableRow Source, swTableItemInsertPosition_e Where, ISingleTableRow Destination);


        //void GetCellRange(out int FirstRow, out int LastRow, out int FirstColumn, out int LastColumn);
        //void SetCellRange(int FirstRow, int LastRow, int FirstColumn, int LastColumn);

        bool SaveAsTemplate(string FileName);
        bool SaveAsText(string FileName, string Separator);


        bool SaveAsPdf(string fileName);
        object HorizontalAutoSplit(int MaxNumberOfRows, swHorizontalAutoSplitApply_e Apply, swHorizontalAutoSplitPlacementOfSplitTable_e PlacementOfNewSplitTables);


        swTableAnnotationType_e Type { get; }
        int BorderLineWeight { get; set; }
        int GridLineWeight { get; set; }
        swBOMConfigurationAnchorType_e AnchorType { get; set; }
        swTextAlignmentVertical_e TextVerticalJustification { get; set; }
        swTextJustification_e TextHorizontalJustification { get; set; }
        int ColumnCount { get; }
        int RowCount { get; }

        string Title { get; set; }
        bool TitleVisible { get; set; }
        bool Anchored { get; set; }


        double BorderLineWeightCustom { get; set; }
        double GridLineWeightCustom { get; set; }

        bool StopAutoSplitting { get; set; }
#endregion
    }

    public interface ISingleTableRow
    {
        ISingleTableAnnotation Table { get; }
        IEnumerable<ISingleTableColumn> Columns { get; }
        IEnumerable<ISingleTableCell> Cells { get; }

        double GetRowHeight();
        double SetRowHeight(double height, swTableRowColSizeChangeBehavior_e Options);
        double RowVerticalGap { get; set; }
        bool LockRowHeight { get; set; }
        bool RowHidden { get; set; }

        bool DeleteRow();
    }

    public interface ISingleTableColumn
    {
        ISingleTableAnnotation Table { get; }
        IEnumerable<ISingleTableRow> Rows { get; }

        double GetColumnWidth { get; }
        double SetColumnWidth(double width, swTableRowColSizeChangeBehavior_e options);

        swTableColumnTypes_e GetColumnType { get; set; }
        string GetColumnTitle { get; set; }
        bool GetLockColumnWidth { get; set; }
        bool ColumnHidden { get; set; }

        bool DeleteColumn();

    }

    public interface ISingleTableCell
    {
        ISingleTableAnnotation Table { get; }
        ISingleTableColumn Column { get; }
        ISingleTableRow Row { get; }


        bool CellUseDocTextFormat { get; set; }
        //Set to null to use doc text format
        TextFormat CellTextFormat { get; set; }


        bool MergeCells(ISingleTableRow rowEnd, ISingleTableColumn columnEnd);
        bool UnMergeCells();


        bool IsCellMerged { get; }
        bool IsCellTextEditable { get; }
        string Text { get; set; }
        string DisplayedText { get; }

        swTextJustification_e TextHorizontalJustification { get; set; }
        swTextAlignmentVertical_e TextVerticalJustification { get; set; }

    }
}
#endif