using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Collections.Generic;
using SingularityBase.Events;
using SolidWorks.Interop.swcommands;

namespace SingularityBase
{
    /// <summary>
    /// ISldWorks Wrapper
    /// </summary>
    public interface ISingleSldWorks : ISolidWorksEvents
    {


        ISldWorks Solidworks { get; }

        /// <summary>
        /// Singularity Addin ID
        /// </summary>
        int AddinId { get; }

        /// <summary>
        /// Converts a path to a document type
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        ISingleModelDoc GetDocumentByName(string name);

        ISingleBaseObject<CommandManager> CommandManager { get; }
        /// <summary>
        /// The Math utility
        /// </summary>
        ISingleMathUtility MathUtility { get; }
        /// <summary>
        /// The Active SW document, if one present
        /// </summary>
        ISingleModelDoc ActiveDocument { get; set; }

        /// <summary>
        /// List of all documents open
        /// </summary>
        IEnumerable<ISingleModelDoc> OpenDocuments { get; }

        /// <summary>
        /// Activates a loaded document and rebuilds it as specified. 
        /// </summary>
        /// <param name="doc">Name of the loaded document to activate</param>
        /// <param name="useUserPreferences">True to rebuild as per the swRebuildOnActivation system option; false to rebuild as per Option</param>
        /// <param name="option">Rebuild option as defined in swRebuildOnActivation_e (see Remarks)</param>
        /// <returns>Status of the activate operation as defined in swActivateDocError_e; if no errors or warnings are encountered, then </returns>
        swActivateDocError_e ActivateDoc(ISingleModelDoc doc, bool useUserPreferences, swRebuildOnActivation_e option);

        
    }



}
