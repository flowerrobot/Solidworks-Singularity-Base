
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Collections.Generic;

namespace SingularityBase
{
    /// <summary>
    /// This is generic for all tables
    /// </summary>
    public interface ISingleTable : ISingleFeature
    {
        IList<ISingleTableAnnotation> TableAnnotations { get; } //IGeneralTableAnnotation 

        //TODO add events for when things change on the UI
    }

    /// <summary>
    /// Wrapper for ITableAnnotation
    /// This is the basis for any table in SW
    /// </summary>
    public interface ISingleTableAnnotation
    {

        ISingleTable Table { get; }
        ITableAnnotation TableAnnotation { get; }
        /// <summary>
        /// Gets the annotation for this table annotation. 
        /// </summary>
        ISingleAnnotation GetAnnotation { get; }
        swTableAnnotationType_e TableType { get; }

        IList<ISingleTableColumn> Columns { get; }
        IList<ISingleTableRow> Rows { get; }

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
        ISingleTableAnnotation Annotation { get; }
        IList<ISingleTableColumn> Columns { get; }
        IList<ISingleTableCell> Cells { get; }

        double GetRowHeight();
        double SetRowHeight(double height, swTableRowColSizeChangeBehavior_e options);
        double RowVerticalGap { get; set; }
        bool LockRowHeight { get; set; }
        bool RowHidden { get; set; }

        int RowIndex { get; }

        bool DeleteRow();
    }

    public interface ISingleTableColumn
    {
        ISingleTableAnnotation Annotation { get; }
        IList<ISingleTableRow> Rows { get; }

        double GetColumnWidth { get; }
        double SetColumnWidth(double width, swTableRowColSizeChangeBehavior_e options);

        swTableColumnTypes_e ColumnType { get; set; }
        string ColumnTitle { get; set; }
        bool LockColumnWidth { get; set; }
        bool ColumnHidden { get; set; }

        int ColumnIndex { get; }

        bool DeleteColumn();

    }

    public interface ISingleTableCell
    {
        ISingleTableAnnotation Annotation { get; }
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
