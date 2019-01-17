using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase
{
    public interface ISelectable
    {
        bool Select(int mark);
        bool Select(bool append, int mark);
        bool DeSelect();
    }
}
