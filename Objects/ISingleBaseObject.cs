using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;

namespace SingularityBase
{

    /// <summary>
    /// A base solidworks object. This wrapper handle disposal of the com object
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISingleBaseObject<T>: IDisposable
    {
        /// <summary>
        /// This is the COM Object. Dealing with the raw object
        /// </summary>
        T BaseObject { get;  }

       
    }

    /// <summary>
    /// Wrapper for IEntity. Used for face, edge, vertex, loop, feature, or document,
    /// </summary>
    public interface ISingleEntity :ISelectable
    {
        /// <summary>
        /// Gets whether this IEntity object survived a rebuild.  
        /// </summary>
        bool IsSafe { get; }

        /// <summary>
        /// Finds an attribute on an entity. 
        /// </summary>
        /// <param name="def">Attribute definition you want to find </param>
        /// <param name="instance">Instance of this type on this entity (0,1,2,3, and so on)</param>
        /// <returns></returns>
        ISingleBaseObject<IAttribute> FindAttribute(AttributeDef def, int instance);


        /// <summary>
        /// The document it belongs to
        /// </summary>
        ISingleModelDoc Document { get; }
        /// <summary>
        /// Gets the owning component for this entity.  
        /// </summary>
        ISingleComponent Component { get; }
        /// <summary>
        /// Gets the drawing component that owns this entity, if the entity is in a drawing view
        /// </summary>
        ISingleDrawingComponent DrawingComponent { get; }

        /// <summary>
        /// Gets the minimum or maximum distance between this entity and the given face or edge entity 
        /// Only face and edge entities are supported
        /// </summary>
        /// <param name="ent"></param>
        /// <param name="minDistance"></param>
        /// <param name="parameter"></param>
        /// <param name="position1"></param>
        /// <param name="position2"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        bool GetDistance(ISingleEntity ent, bool minDistance, object parameter,out double[] position1,out double[] position2, out double distance);
    }
}
