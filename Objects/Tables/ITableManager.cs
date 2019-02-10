using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase
{
    public interface ITableManager
    {
        ISingleModelDoc Document { get; }

        /// <summary>
        /// Gets all tables \ BOMs \ revision tables in a file
        /// </summary>
       // IEnumerable<ISingleTableAnnotation> GetAllTables();



        IList<ISingleWeldmentCutListTable> GetWeldmentTables { get; }
        IList<ISingleBomTable> GetBomTables { get; }
    }
}
