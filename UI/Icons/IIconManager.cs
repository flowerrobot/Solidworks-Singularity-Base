using System.Collections.Generic;
using System.Drawing;

namespace SingularityBase.UI
{ 
    public interface IIconManager
    {
         NLog.Logger Logger { get; }
        string ImagePathSize20 { get; }
        string ImagePathSize32 { get; }
        string ImagePathSize40 { get; }
        string ImagePathSize64 { get; }
        string ImagePathSize96{ get; }
        string ImagePathSize128 { get; }

        string AddinIconSize20 { get; }
        string AddinIconSize32 { get; }
        string AddinIconSize40 { get; }
        string AddinIconSize64 { get; }
        string AddinIconSize96 { get; }
        string AddinIconSize128 { get; }


        List<ISingleCommandDef> Images { get; }
        
        /// <summary>
        /// Merge Image files together
        /// </summary>
        /// <returns></returns>
        bool AppendImages();

        //TODO Add 20-128 defaults
        /// <summary>
        /// Default small icon
        /// </summary>
        /// <returns></returns>
         Bitmap DefaultSize20 { get; }

        /// <summary>
        /// Default Large Icon
        /// </summary>
        /// <returns></returns>
        Bitmap DefaultSize32{ get;}

        /// <summary>
        /// Extracts the image from the resources and saves it in the temp location
        /// </summary>
        /// <param name="img">The img.</param>
        /// <returns></returns>
        string ExtractImage(Bitmap img);
    }
}
