
using SingularityBase;
using SingularityBase.UI;
using System.Drawing;

namespace SingularityBase.UI
{
    /// <summary>
    /// Defines image definition for a button class
    /// Best to have the icons stored as Bitmap resources and simply pass that here
    /// </summary>
    public sealed class IconDef : IIconDef
    {
        public IconDef(ISwBaseFunction owner)
        {
            Owner = owner;
        }

        /// <summary>
        /// The small icon size 16. ie Properties.Resouces.MySmallIcon;
        /// </summary>
        /// public Bitmap ImageSize16 { get; set; }

        /// <inheritdoc />
        public Bitmap ImageSize20 { get; set; }

        /// <inheritdoc />
        public Bitmap ImageSize32 { get; set; }

        /// <inheritdoc />
        public Bitmap ImageSize40 { get; set; }

        /// <inheritdoc />
        public Bitmap ImageSize64 { get; set; }

        /// <inheritdoc />
        public Bitmap ImageSize96 { get; set; }

        /// <inheritdoc />
        public Bitmap ImageSize128 { get; set; }

        /// <summary>
        /// The position found on the combined tool bar
        /// </summary>
        ///public int Index { get; internal set; }

        /// <summary>
        /// Module who owns this icon profile
        /// </summary>
        public ISwBaseFunction Owner { get; internal set; }


    }
}
