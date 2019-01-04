using System.Drawing;

namespace SingularityBase.UI
{
    /// <summary>
    /// Defines image definition for a button class
    /// Best to have the icons stored as Bitmap resources and simply pass that here
    /// </summary>
    public interface IIconDef
    {
        /// <summary>
        /// The small icon size 16 or 20, if blank default will be used
        /// </summary>
        Bitmap ImageSize20 { get; set; }
        /// <summary>
        /// The large icon size 32 -  if blank default will be used
        /// </summary>
        Bitmap ImageSize32 { get; set; }
        /// <summary>
        /// The large icon size 40, if empty 32 will be used
        /// </summary>
        Bitmap ImageSize40 { get; set; }
        /// <summary>
        /// The large icon size 64, if empty 32 will be used
        /// </summary>
        Bitmap ImageSize64 { get; set; }
        /// <summary>
        /// The large icon size 96, if empty 32 will be used
        /// </summary>
        Bitmap ImageSize96 { get; set; }
        /// <summary>
        /// The large icon size 128, if empty 32 will be used
        /// </summary>
        Bitmap ImageSize128 { get; set; }                      
        
        
        /// <summary>
        /// Module who owns this icon profile
        /// </summary>
        ISwBaseFunction Owner { get; }
    }
}
