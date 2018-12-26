using System.Drawing;

namespace SingularityBase.UI.Icons
{
    public interface IIconDef
    {
        /// <summary>
        /// The small icon size 16 or 20 - Can not be blank
        /// </summary>
        Bitmap ImageSize20 { get; set; }
        /// <summary>
        /// The large icon size 32 - Can not be blank
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
        /// THe postion found on the combined tool bar
        /// </summary>
        int Index { get; }
        /// <summary>
        /// Module who owns this icon profile
        /// </summary>
        ISwBaseFunction Owner { get; }
    }
}
