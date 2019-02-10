using SingularityBase.Events;
using SolidWorks.Interop.sldworks;
using System.Collections.Generic;
using SolidWorks.Interop.swconst;

namespace SingularityBase
{
    public interface ISingleDrawingDoc : ISingleModelDoc, IDrawingEvents
    {
        DrawingDoc Document { get; }

        ISingleView GetFirstView { get; }
        ISingleView GetNextView(ISingleView view);
        /// <summary>
        /// Will return a full list of views in this file right now. Used for easy enumerations. Not to be kept for peristalsis as views might be added or deleted
        /// </summary>
        IList<ISingleView> Views { get; }

        /// <summary>
        /// Creates a flat-pattern view from a model view.  
        /// </summary>
        /// <returns></returns>
        ISingleView CreateFlatPatternViewFromModelView(ISinglePoint lowerLeft, string modelName, string configName, bool hideBendLines, bool flipView); 

        /// <summary>
        /// Creates a drawing view on the current drawing sheet using the specified model view. 
        /// </summary>
        /// <returns></returns>
        ISingleView CreateDrawViewFromModelView(ISinglePoint lowerLeft, string modelName, string viewName);

        /// <summary>
        /// Creates a an empty view in a drawing.  
        /// </summary>
        ISingleView CreateViewport(ISinglePoint lowerLeft, int size, double scale);

        /// <summary>
        /// Creates an auxiliary view based on a selected edge in a drawing view. 
        /// </summary>
        /// <param name="lowerLeft"></param>
        /// <param name="aligned"></param>
        /// <param name="lable"></param>
        /// <param name="showArrow"></param>
        /// <param name="flipView"></param>
        /// <returns></returns>
        ISingleView CreateAuxiliaryView(ISinglePoint lowerLeft, bool aligned, string label, bool showArrow, bool flipView);

        /// <summary>
        /// Creates an unfolded drawing view from the selected drawing view and places it in the drawing at the specified location. 
        /// </summary>
        /// <param name="lowerLeft"></param>
        /// <param name="aligned"></param>
        /// <returns></returns>
        ISingleView CreateUnfoldedView(ISinglePoint lowerLeft, bool aligned);

        /// <summary>
        /// Creates a relative drawing view. 
        /// </summary>
        /// <returns></returns>
        ISingleView CreateRelativeView(ISinglePoint lowerLeft, ISingleModelDoc doc, swRelativeViewCreationDirection_e front,swRelativeViewCreationDirection_e right);




        /// <summary>
        /// Activates the specified drawing sheet.  
        /// </summary>
        string ActiveSheet { get; set; }
    }

   
}
