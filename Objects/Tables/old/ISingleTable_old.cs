using SolidWorks.Interop.sldworks;
using System;

namespace SingularityBase
{
    [Obsolete("I don't think this needs to be used")]
    public interface ISingleTable_old : ISelectable
    {
        double GetExtent { get; }

        string GetHeaderText(int Col);
        string GetCellText(int Row, int Col);



        /// <summary>
        /// This activates the BOM
        /// </summary>
        bool IsActive { get; set; }
        [Obsolete("Use isActive")]
        bool Attach();
        [Obsolete("Use isActive")]
        bool Detach();



        //double GetColumnWidth(int Col);
        //double GetRowHeight(int Row);
        //object GetEntryValue(int Row, int Col);

        DisplayData GetDisplayData { get; }

        bool IsVisible { get; }
        int RowCount { get; }
        int ColumnCount { get; }


    }
}
