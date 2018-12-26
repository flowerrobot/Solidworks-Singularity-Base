using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingularityBase.Managers
{
    public interface ISingleConfiguration
    {
        string ConfigName { get; set; }
        ISingleModelDoc Doc { get; }
        IConfiguration Configuration { get; }
        ISingleCustomPropertyManager CustomPropertyManager { get; }
    }
}
